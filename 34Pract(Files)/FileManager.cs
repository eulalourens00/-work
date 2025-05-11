using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34Pract_Files_
{
    //1
    public class FileManager
    {
        private const string FileName = "Day17.txt";
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Создать новый файл");
                Console.WriteLine("2. Прочитать файл");
                Console.WriteLine("3. Записать данные в файл");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateFile();
                        break;
                    case "2":
                        ReadFile();
                        break;
                    case "3":
                        WriteDataToFile();
                        break;
                    case "4":
                        return;
                    default:
                        throw new InvalidDataException();
                        break;
                }
            }
        }

        private void CreateFile()
        {
            if (File.Exists(FileName))
            { Console.WriteLine("Файл уже существует."); return; }

            File.Create(FileName).Close();
            Console.WriteLine("Файл успешно создан.");
        }

        private void ReadFile()
        {
            if (!File.Exists(FileName))
            { Console.WriteLine("Файл не существует!"); return; }

            try
            {
                string[] lines = File.ReadAllLines(FileName);

                if (lines.Length == 0)
                { Console.WriteLine("Файл пуст."); return;}

                Console.WriteLine($"ФИО и дата рождения: {lines[0]}");

                string[] doubleSize = lines[1].Split(' ');
                int doubleRows = int.Parse(doubleSize[0]);
                int doubleCols = int.Parse(doubleSize[1]);

                Console.WriteLine("\nМассив дробных чисел:");
                for (int i = 0; i < doubleRows; i++)
                { Console.WriteLine(lines[2 + i]);}

                string[] intSize = lines[2 + doubleRows].Split(' ');
                int intRows = int.Parse(intSize[0]);
                int intCols = int.Parse(intSize[1]);

                Console.WriteLine("\nМассив целых чисел:");
                string[] intValues = lines[3 + doubleRows].Split(' ');
                for (int i = 0; i < intRows; i++)
                {
                    for (int j = 0; j < intCols; j++)
                    { Console.Write(intValues[i * intCols + j] + " "); }
                    Console.WriteLine();
                }

                Console.WriteLine($"\nДата записи: {lines[4 + doubleRows]}");
            }

            catch (Exception ex)
            { Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");}
        }

        private void WriteDataToFile()
        {
            if (!File.Exists(FileName))
            { Console.WriteLine("Файла не существует. Сначала создайте файл."); return;}

            try
            {
                Console.WriteLine("Введите ФИО и дату рождения (формат: Иванов Иван Иванович 01.01.1990):");
                string personalData = Console.ReadLine();

                Console.WriteLine("Введите размеры массива дробных чисел (строки столбцы):");
                string[] doubleSize = Console.ReadLine().Split(' ');
                int doubleRows = int.Parse(doubleSize[0]);
                int doubleCols = int.Parse(doubleSize[1]);

                double[,] doubleArray = new double[doubleRows, doubleCols];
                Console.WriteLine($"Введите {doubleRows * doubleCols} дробных чисел:");

                for (int i = 0; i < doubleRows; i++)
                {
                    string[] rowValues = Console.ReadLine().Split(' ');
                    for (int j = 0; j < doubleCols; j++)
                    { doubleArray[i, j] = double.Parse(rowValues[j], CultureInfo.InvariantCulture);}
                }

                Console.WriteLine("Введите размеры массива целых чисел (строки столбцы):");
                string[] intSize = Console.ReadLine().Split(' ');
                int intRows = int.Parse(intSize[0]);
                int intCols = int.Parse(intSize[1]);

                int[,] intArray = new int[intRows, intCols];
                Console.WriteLine($"Введите {intRows * intCols} целых чисел в одну строку:");

                string[] intValues = Console.ReadLine().Split(' ');
                for (int i = 0; i < intRows; i++)
                {
                    for (int j = 0; j < intCols; j++)
                    { intArray[i, j] = int.Parse(intValues[i * intCols + j]);}
                }

                using (StreamWriter writer = new StreamWriter(FileName))
                {
                    writer.WriteLine(personalData);

                    writer.WriteLine($"{doubleRows} {doubleCols}");
                    for (int i = 0; i < doubleRows; i++)
                    {
                        for (int j = 0; j < doubleCols; j++)
                        { writer.Write(doubleArray[i, j].ToString(CultureInfo.InvariantCulture) + " "); }
                        writer.WriteLine();
                    }

                    writer.WriteLine($"{intRows} {intCols}");
                    for (int i = 0; i < intRows; i++)
                    {
                        for (int j = 0; j < intCols; j++)
                        { writer.Write(intArray[i, j] + " "); }
                    }
                    writer.WriteLine();

                    writer.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
                }

                Console.WriteLine("Данные успешно записаны в файл.");
            }

            catch (Exception ex)
            {  Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");}
        }
    }
}
