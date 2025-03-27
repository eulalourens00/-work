namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //List<Student> students = new List<Student>()
            //{
            //    new Student() {
            //        FirstName = "Leeky",
            //        LastName = "Suya",
            //        Date = new DateTime(2007, 12, 27)
            //    },
            //    new Student() {
            //        FirstName = "Pipapo",
            //        LastName = "Uiyd",
            //        Date = new DateTime(2007, 10, 13)
            //    },
            //    new Student() {
            //        FirstName = "Reesiy",
            //        LastName = "Veny",
            //        Date = new DateTime(2007, 3, 9)
            //    },

            //};

            //Teacher teacher = new Teacher();
            //foreach (Student student in students)
            //{
            //    teacher.examEvent += student.Exam;
            //}
            //ExamEventArgs eventArgs = new ExamEventArgs { Task = "TASK"};
            //teacher.Exam(eventArgs);


            //foreach (Student student in students) {
            //    teacher.examEvent += student.Exam;
            //}
            //teacher.examEvent.Invoke("Overall rating 2!");
            //teacher.examEvent = null;
            //teacher.Exam("Test");


            Account acc = new Account(200);
            acc.notify += Print;
            acc.Put(2000);
            acc.Take(10000);

        }

        static void Print(string mess)
        {
            Console.WriteLine(mess);
        }
    }
}
