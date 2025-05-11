using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _34Pract_Files_
{
    //2
    public class CodeAnalyzer
    {
        public void ProcessCode(string inputFile, string outputFile)
        {
            try
            {
                string[] lines = File.ReadAllLines(inputFile);
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    foreach (string line in lines)
                    {
                        string trimmedLine = Regex.Replace(line.Trim(), @"\s+", " ");

                        string processedLine = Regex.Replace(
                            trimmedLine,
                            @"public\s+(?!class\b|interface\b|struct\b|enum\b)[a-zA-Z]+\s+([a-zA-Z_])",
                            "private $1"
                        );

                        processedLine = Regex.Replace(
                            processedLine,
                            @"\b[a-zA-Z]{3,}\b",
                            m => m.Value.ToUpper()
                        );

                        char[] charArray = processedLine.ToCharArray();
                        Array.Reverse(charArray);
                        writer.WriteLine(new string(charArray));
                    }
                }

                Console.WriteLine($"Результат записан в {outputFile}");
            }

            catch (Exception ex)
            { Console.WriteLine($"Ошибка: {ex.Message}");}

            //господипомоги
        }
    }
}
