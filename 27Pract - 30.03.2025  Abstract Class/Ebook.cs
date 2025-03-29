using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Ebook : Edition
    {
        public string Title { get; set; }
        public string LastNameAuthor { get; set; }
        public string Link {  get; set; }


        public Ebook(string title, string lastnameauthor, string link)
        {
            Title = title;
            LastNameAuthor = lastnameauthor;
            Link = link;
        }
        public override void Print()
        {
            Console.WriteLine($"{Title} by {LastNameAuthor}. \n{Link}");
            Console.WriteLine();
        }
        public override bool Find(string LastNameAuthor)
        {
            return this.LastNameAuthor.Equals(LastNameAuthor, StringComparison.OrdinalIgnoreCase);
        }  
        
        public void Annotaton()
        {
            Console.WriteLine("Статья посвящена проблеме создания, сложности внедрения и использования информационных технологий в практике библиотек. " +
                "Подробно рассмотрены технологические процессы, осуществляемые библиотекой. Раскрываются вопросы лёгкого внедрения технологий в рабочий процесс. " +
                "Статья полезна для преподавателей и студентов, библиотечным работникам.");
        }
    }
}
