namespace partial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass.Method1();
            //MyClass.Method2();

            //Emp emp1 = new Emp("Leeky", "Suya", 370000.22);
            //emp1.Print();

            //Emp2 emp2 = new Emp2("Nastya", "Korol", 1020323.32);
            //emp2.Print();

            //Console.WriteLine();
            //emp1.Show();

            //Learner[] learners =
            //{
            //    new Student("Asya", "Leeky", new DateTime(2007, 5, 15), "It-top", "23/3 Dev"),
            //    new SchoolChild("Dasha", "Vos", new DateTime(2007, 10, 24), "GBOU 3", "11A")
            //};

            //foreach (Learner learner in learners)
            //{
            //    //learner.Print();
            //    Console.WriteLine(learner); //переопределили ф-и Print с помощью ToString
            //    learner.Think();
            //    learner.Study();
            //}

            Student st = new Student(
                "Ivan", "Iva", new DateTime(2000, 1, 2), "Uni", "1r");
            Console.WriteLine($"name = {st.GetType().FullName}");

            Console.WriteLine($"Elem is {st.GetType().Name}");
            Console.WriteLine($"Basic class el - {st.GetType().BaseType}");
            Console.WriteLine($"Abstact? - {st.GetType().IsAbstract}");
            Console.WriteLine($"Claa? - {st.GetType().IsClass}");
            Console.WriteLine($"Можно ли получить объекты за пределами сборки? - {st.GetType().IsVisible}");
        
        }

    }
}
