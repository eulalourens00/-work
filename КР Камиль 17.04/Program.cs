namespace КР_Камиль_17._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            //ArrayString();
            //RandomNumbers();
            //2.
            Fraction fraction = new Fraction(2, 5, 1, 2);
            fraction.Summa();
            fraction.Div();
        }
        //1.
        static void ArrayString()
        {
            Console.WriteLine("Sentence: ");
            string[] text = Console.ReadLine().ToLower().Trim().Split();
            var set = new HashSet<string>(text);
            var sortedList = set.OrderBy(word => word.Length).ToList();
            foreach (var word in sortedList)
            {  Console.Write(word + " ");}
            Console.WriteLine();
        }
        //1.1
        static void RandomNumbers()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 20; i++) { numbers.Add(random.Next(-50, 50)); }
            Console.WriteLine($"Start list: {String.Join(' ', numbers)}");
            int countP = 0; int countN = 0;
            for (int i = 0; i < numbers.Count; i++) {
                if (numbers[i] < 0) { countN++; }
                else { countP++; }
            }
            Console.WriteLine($"Positive values count: {countP}\nNegative: {countN}");
            int sumP = 0;
            for (int i = 0; i < numbers.Count; i++)
            {  if (numbers[i] > 0) { sumP += numbers[i]; } }
            Console.WriteLine($"Summa of positive values: {sumP}");
            numbers.Sort();
            numbers.Reverse();
            Console.WriteLine($"Finish list after descending: {String.Join(' ', numbers)}");
        }
    }
}
