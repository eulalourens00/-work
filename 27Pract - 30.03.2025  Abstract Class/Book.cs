using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Book : Edition   
    {
        public string Title { get; set; }
        public string LastNameAuthor { get; set; }
        public int YearOfShow { get; set; }
        public string NameOrganization { get; set; }

        public Book(string title, string lastnameauthor, int year, string organization) {
            Title = title;
            LastNameAuthor = lastnameauthor;
            YearOfShow = year;
            NameOrganization = organization;
        }
        public override void Print()
        {
            Console.WriteLine($"{Title} of {YearOfShow} by {LastNameAuthor}. \n{NameOrganization}");
            Console.WriteLine();
        }
        public override bool Find(string LastNameAuthor)
        {
            return this.LastNameAuthor.Equals(LastNameAuthor, StringComparison.OrdinalIgnoreCase);
        }
    }
}
