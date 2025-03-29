using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Article : Edition
    {
        public string Title { get; set; }
        public string LastNameAuthor { get; set; }
        public string NameMagazine { get; set; }
        public int YearMagazine { get; set; }
        public int Codemagazine { get; set; }

        public Article(string title, string lastnameauthor, int year, string namemagazine, int code)
        {
            Title = title;
            LastNameAuthor = lastnameauthor;
            YearMagazine = year;
            NameMagazine = namemagazine;
            Codemagazine = code;
        }
        public override void Print()
        {
            Console.WriteLine($"{Title} by {LastNameAuthor}. \n{NameMagazine} of {YearMagazine}. [{Codemagazine}]");
            Console.WriteLine();
        }
        public override bool Find(string LastNameAuthor)
        {
            return this.LastNameAuthor.Equals(LastNameAuthor, StringComparison.OrdinalIgnoreCase);
        }
    }
}
