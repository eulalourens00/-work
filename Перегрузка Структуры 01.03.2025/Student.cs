using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_Структуры_01._03._2025
{
    internal class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }
        public int[][] Marks { get; set; }

        public Student(string lname, string fname, string group, int age, int[][] marks) {
            LastName = lname;
            FirstName = fname;
            Group = group;
            Age = age;
            Marks = marks;
        }
        //новая оценка
        public void NewMark(int IndexSubject, int IndexMark, int Mark)
        {
            Marks[IndexSubject][IndexMark] = Mark;
        }
        //вывести определенную оценку
        public int GetMark(int IndexSubject, int IndexMark)
        {
            return Marks[IndexSubject][IndexMark];
        }
        public double MiddleMark(int IndexSubject)
        {
            int summa = 0;
            foreach(var grade in Marks[IndexSubject]) { summa += grade; }
            return Math.Round((summa / (double)Marks[IndexSubject].Length), 2);
        }

        public void Info()
        {
            Console.WriteLine($" Full Name: {LastName} {FirstName}\n Marks: " +
                $" Programming: {string.Join(" ", Marks[0])} "
                + $" Admin: {string.Join(" ", Marks[1])}" + $" Design: {string.Join(" ", Marks[2])}"
                );
        }

    }
}
