namespace _34Pract_Files_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            FileManager fileManager = new FileManager();
            fileManager.Run();

            //2
            Console.WriteLine("Введите путь к файлу с исходным кодом:");
            string inputFile = Console.ReadLine();

            Console.WriteLine("Введите путь для сохранения результата:");
            string outputFile = Console.ReadLine();

            CodeAnalyzer code = new CodeAnalyzer();
            code.ProcessCode(inputFile, outputFile);

            //3
            string fileName = "mytest.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Привет");
                    writer.WriteLine("(это мой первый хейт)");
                    writer.WriteLine("аалеее оп mytest.txt");
                }

                Console.WriteLine($"Файл создан с именем {fileName}");
            }
            catch (Exception ex)
            { Console.WriteLine($"Ошибка: {ex.Message}");}

            //4
            string fileName1 = "mytest1.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName1))
                {
                    writer.WriteLine("Пока");
                    writer.WriteLine("(это мой первый респект)");
                    writer.WriteLine("гулигулигули mytest1.txt");
                }

                Console.WriteLine($"Cодержимое файла {fileName1}:");
                Console.WriteLine("----------------------------------");

                string[] lines = File.ReadAllLines(fileName1);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            { Console.WriteLine($"Ошибка: {ex.Message}"); }
        }
    }
}
