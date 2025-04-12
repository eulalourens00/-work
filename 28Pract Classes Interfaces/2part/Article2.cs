using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Pract_Classes_Interfaces
{
    public class Article2 : IRateAndCopy
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Rating { get; private set; }
        public Article2(string title, string author, double rating)
        {
            Title = title;
            Author = author;
            Rating = rating;
        }

        public object DeepCopy()
        {
            return new Article2(Title, Author, Rating);
        }
        

    }
}
