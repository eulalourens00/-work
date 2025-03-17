using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    class ExamEventArgs : EventArgs
    {
        public string Task { get; set; }
    }
    internal class Student
    {
        public delegate void ExamDelegate(string t);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date {  get; set; }
        public void Exam(object sender, ExamEventArgs e)
        {
            Console.WriteLine($"Student: {LastName} solved the {e.Task}");
        }
    }
}
