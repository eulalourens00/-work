using _28Pract_Classes_Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _28Pract_Classes_Interfaces.Article;

public class Magazine : Article
{
    private string nameOfMagazine;
    private Frequency type;
    private DateTime dateTime;
    private int serialNumber;
    private List<Article> articles;

    public Magazine()
    { articles = new List<Article>();}

    public Magazine(string name, Frequency type, DateTime date, int serial, List<Article> articles)
    {
        this.nameOfMagazine = name;
        this.type = type;
        this.dateTime = date;
        this.serialNumber = serial;
        this.articles = articles ?? new List<Article>();
    }

    public string NameOfMagazine
    {
        get { return nameOfMagazine; }
        set { nameOfMagazine = value; }
    }

    public Frequency Type
    {
        get { return type; }
        set { type = value; }
    }

    public DateTime DateTime
    {
        get { return dateTime; }
        set { dateTime = value; }
    }

    public int SerialNumber
    {
        get { return serialNumber; }
        set { serialNumber = value; }
    }

    public List<Article> Articles
    {
        get { return articles; }
        set { articles = value ?? new List<Article>(); }
    }

    public double MiddleRating
    {
        get
        {
            if (Articles.Count > 0) { return Articles.Average(article => article.Rating); }
            return 0;
        }
    }

    public bool this[Frequency frequency]
    {
        get { return Type == frequency; }
    }

    public void AddArticle()
    {
        Console.Write("Enter the TITLE of the new article: ");
        string title = Console.ReadLine();

        Console.Write("Enter the RATING of the new article: ");
        double rating = Convert.ToDouble(Console.ReadLine());

        Article newArticle = new Article
        {
            Title = title,
            Rating = rating
        };

        articles.Add(newArticle);
    }

    public override string ToString()
    {
        return $"Darling! Here is your new magazine! ^^" +
               $"\nIts {NameOfMagazine} - {SerialNumber} : {dateTime.ToShortDateString()}\n" +
               $"Frequency is {Type}\n" +
               $"\n\n{string.Join(", ", articles.Select(a => a.ToString()))}";
    }

    public virtual string ToShortString()
    {
        return $"\nDarling! Here is your new magazine! ^^" +
               $"\nIts {NameOfMagazine} - {SerialNumber} : {dateTime.ToShortDateString()}\n" +
               $"Frequency is {Type}\n" +
               $"Rating of articles: {MiddleRating}";
    }
}
