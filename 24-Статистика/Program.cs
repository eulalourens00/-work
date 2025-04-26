namespace _24_Статистика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            var textNow = new string(text.Where(c => !char.IsPunctuation(c)).ToArray()).ToLower();

            string[] words = textNow.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (result.ContainsKey(word))
                {  result[word]++; }
                else
                {  result.Add(word, 1); }
            }
            Console.WriteLine("Слово\t\tКоличество");
            Console.WriteLine("-----------------------");
            foreach (var pair in result.OrderByDescending(pair => pair.Value))
            {  Console.WriteLine($"{pair.Key}\t\t{pair.Value}"); }
        }
    }
}
