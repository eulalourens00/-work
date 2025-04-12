using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Pract_Classes_Interfaces
{
    public class Magazine2 : Edition
    {
        private Frequency Type;
        private List<Person2> Authors;
        private List<Article2> ListArticles;
        public enum Frequency { Daily, Weekly, Monthly}
        public Magazine2()
        {
            Authors = new List<Person2>();
            ListArticles = new List<Article2>(); 
        }
        public Magazine2(Frequency type, List<Person2> authors, List<Article2> list_articles)
        {
            this.Type = type;
            this.Authors = authors ?? new List<Person2>();
            this.ListArticles = list_articles ?? new List<Article2>();
        }
        public Frequency _Type
        {
            get { return Type; }
            set { Type = value; }
        }
        public List<Person2> _Authors
        {
            get { return Authors; }
            set { Authors = value ?? new List<Person2>(); }
        }
        public List<Article2> _ListArticles
        {
            get { return ListArticles; }
            set { ListArticles = value ?? new List<Article2>(); }
        }
        public double MiddleRating
        {
            get
            {
                if (ListArticles.Count > 0) { return ListArticles.Average(article => article.Rating); }
                return 0;
            }
        }


        public void AddArticle()
        {
            Console.Write("Enter the TITLE of the new article: ");
            string title = Console.ReadLine();

            Console.Write("Enter the AUTHOR of the new article: ");
            string author = Console.ReadLine();

            Console.Write("Enter the RATING of the new article: ");
            double rating = Convert.ToDouble(Console.ReadLine());

            Article2 newArticle = new Article2(title, author, rating);
            ListArticles.Add(newArticle);
        }

        public override string ToString()
        {
            return $"Magazine: {Title}\n" +
                   $"Frequency: {Type}\n" +
                   $"Articles:\n{string.Join("\n", ListArticles.Select(a => a.ToString()))}";
        }

        public virtual string ToShortString()
        {
            return $"Average rating: {MiddleRating}";
        }

        public IEnumerable<Article2> GetArticlesWithRatingGreaterThan(double minRating)
        {
            foreach (var article in ListArticles)
            {
                if (article.Rating > minRating)
                { yield return article; }
            }
        }

        public IEnumerator<Article2> GetEnumerator()
        { return ListArticles.GetEnumerator(); }
    }
}
