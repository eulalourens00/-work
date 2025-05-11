using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33Pract
{
    //1.
    public class Translator
    {
        private readonly Dictionary<string, string> _engToRus;
        private readonly Dictionary<string, string> _rusToEng;

        public Translator()
        {
            _engToRus = new Dictionary<string, string>
        {
            {"united kingdom", "великобритания"},
            {"united states", "соединенные штаты"},
            {"germany", "германия"},
            {"france", "франция"},
            {"italy", "италия"}
        };

            _rusToEng = new Dictionary<string, string>
        {
            {"великобритания", "united kingdom"},
            {"соединенные штаты", "united states"},
            {"германия", "germany"},
            {"франция", "france"},
            {"италия", "italy"}
        };
        }

        public string Translate(string direction, string word)
        {
            word = word.ToLower();

            try
            {
                return direction == "1"
                    ? _engToRus[word]
                    : _rusToEng[word];
            }
            catch (KeyNotFoundException)
            {
                return "No word.";
            }
        }
    }
}
