using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _32Pract_Счет_для_оплаты
{
    [Serializable]
    public class Pay
    {
        public static bool SerializeCalculatedFields { get; set; } = false;

        public decimal DailyPayment { get; set; }
        public int DaysCount { get; set; }
        public decimal DailyPenalty { get; set; }
        public int DelayDays { get; set; }

        [NonSerialized]
        private decimal _totalWithoutPenalty;
        public decimal TotalWithoutPenalty => _totalWithoutPenalty;

        [NonSerialized]
        private decimal _penaltyAmount;
        public decimal PenaltyAmount => _penaltyAmount;

        [NonSerialized]
        private decimal _totalAmount;
        public decimal TotalAmount => _totalAmount;

        public Pay(decimal dailyPayment, int daysCount, decimal dailyPenalty, int delayDays)
        {
            DailyPayment = dailyPayment;
            DaysCount = daysCount;
            DailyPenalty = dailyPenalty;
            DelayDays = delayDays;
            CalculateAmounts();
        }

        private void CalculateAmounts()
        {
            _totalWithoutPenalty = DailyPayment * DaysCount;
            _penaltyAmount = DailyPenalty * DelayDays;
            _totalAmount = _totalWithoutPenalty + _penaltyAmount;
        }

        public void SaveToFile(string filePath)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                if (SerializeCalculatedFields)
                {
                    var data = new PayData(this);
                    File.WriteAllText(filePath, JsonSerializer.Serialize(data, options));
                }
                else
                {
                    File.WriteAllText(filePath, JsonSerializer.Serialize(this, options));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка сохранения: {ex.Message}");
            }
        }

        public static Pay LoadFromFile(string filePath)
        {
            try
            {
                var json = File.ReadAllText(filePath);
                if (SerializeCalculatedFields)
                {
                    var data = JsonSerializer.Deserialize<PayData>(json);
                    return new Pay(data.DailyPayment, data.DaysCount,
                                  data.DailyPenalty, data.DelayDays);
                }
                else
                {
                    var pay = JsonSerializer.Deserialize<Pay>(json);
                    pay.CalculateAmounts();
                    return pay;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка загрузки: {ex.Message}");
                return null;
            }
        }

        public override string ToString() =>
            $"Оплата за день: {DailyPayment:C}\n" +
            $"Количество дней: {DaysCount}\n" +
            $"Штраф за день задержки: {DailyPenalty:C}\n" +
            $"Дней задержки: {DelayDays}\n" +
            $"Сумма без штрафа: {TotalWithoutPenalty:C}\n" +
            $"Штраф: {PenaltyAmount:C}\n" +
            $"Общая сумма: {TotalAmount:C}";

        [Serializable]
        private class PayData
        {
            public decimal DailyPayment { get; set; }
            public int DaysCount { get; set; }
            public decimal DailyPenalty { get; set; }
            public int DelayDays { get; set; }
            public decimal TotalWithoutPenalty { get; set; }
            public decimal PenaltyAmount { get; set; }
            public decimal TotalAmount { get; set; }

            public PayData(Pay pay)
            {
                DailyPayment = pay.DailyPayment;
                DaysCount = pay.DaysCount;
                DailyPenalty = pay.DailyPenalty;
                DelayDays = pay.DelayDays;
                TotalWithoutPenalty = pay.TotalWithoutPenalty;
                PenaltyAmount = pay.PenaltyAmount;
                TotalAmount = pay.TotalAmount;
            }
        }
    }
}

