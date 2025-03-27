using System.Text.RegularExpressions;
namespace Regeexx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Но элементы ной новогодний новый представляют собой политический процесс мяу";
            Regex regex = new Regex(@"но(\w*)");
            MatchCollection mathCollection = regex.Matches(s);
            if (mathCollection.Count > 0) { 
                foreach(Match match in mathCollection)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else { Console.WriteLine("No"); }

            //RegexOptions.Compiled
        }
    }
}
