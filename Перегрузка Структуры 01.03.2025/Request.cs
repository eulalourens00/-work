using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_Структуры_01._03._2025
{
    public struct Request
    {
        public string CodeOrder;
        public string Client;
        public DateTime DateOfOrder;
        public List<string> GoodsInOrders;
        public double GoodsSumma;
        public PayType Type;

        public Request(string code, string client, DateTime date, List<string> goods, double summa, PayType type)
        {
            CodeOrder = code;
            Client = client;
            DateOfOrder = date;
            GoodsInOrders = goods;
            GoodsSumma = summa;
            Type = type;
        }

        public override string ToString() 
        {
            return $" Code: {CodeOrder}\n Client: {Client}\n Date: {DateOfOrder.ToShortDateString}\n Orders: {GoodsInOrders}\n Summa: {GoodsSumma}\n Pay: {Type}";
        }
    }
    public enum PayType { 
        Card, Online, Cash, Bonuses
    }
}
