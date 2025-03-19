using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Pract_24._03._2025_
{
    internal class GuessNumber
    {
        public int Guess { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        Random rnd = new Random();

        public GuessNumber(int guess, int start, int end)
        {
            Guess = guess;
            Start = start;
            End = end;
        }
        public void TryGuess()
        {
            int attemp = rnd.Next(Start, End);
            Console.WriteLine($"Computer number = {attemp}");
            if (attemp == Guess) { Console.WriteLine($"Win! My number was {Guess}! You got it."); }
            else { Console.WriteLine($"Oh, not now. My number was {Guess}"); }
        }
    }
}
