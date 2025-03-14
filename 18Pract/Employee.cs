using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Pract
{
    internal class Employee
    {
        public string LastFirstName { get; set; }
        public string Work { get; set; }
        public string Email { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public List<string> Task { get; set; } = new List<string>();

        public void AddData()
        {
            Console.WriteLine("\t--Add data about employee--");
            Console.Write("Last and first names: ");
            LastFirstName = Console.ReadLine();
            Console.Write("\nPost: ");
            Work = Console.ReadLine();

            Console.Write("\nDate of birth (format: yyyy-MM-dd): ");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime birthday)) { BirthDay = birthday; } else { throw new InvalidOperationException(); }

            Console.Write("\nPhone: ");
            Phone = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("\t--Tasks (press empty string to finish)--");
            Console.WriteLine("Task: ");
            while (true)
            {
                string task = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(task)) { break; }
                Task.Add(task);
            }
        }

        public override string ToString()
        {
            return $"{LastFirstName}. Post - {Work}. \n" +
                $"Email - {Email}. Phone - {Phone} \n"
                + $"Tasks: {string.Join(", ", Task)}";
        }

        public void GetName()
        {
            Console.WriteLine($"Im {LastFirstName}");
        }
        public void GetPost()
        {
            Console.WriteLine($"Im {Work}");
        }
        public void GetEmail()
        {
            Console.WriteLine($"{Email}");
        }
        public void GetPhone()
        {
            Console.WriteLine($"{Phone}");
        }
        public void GetTask()
        {
            Console.WriteLine($"To Do List: {string.Join(", ", Task)}");
        }
    }
}
