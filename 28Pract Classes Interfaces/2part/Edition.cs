using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28Pract_Classes_Interfaces
{
    public class Edition
    {
        protected string Title;
        protected DateTime Date;
        protected int Number;

        public Edition(string title, int number) { Title = title; Number = number; }
        public Edition() { }
        public string _Title { get { return Title; } set { Title = value; } }
        public DateTime _Date {  get { return Date; } set { Date = value; } }
        public int _Number { get { return Number; } set { if (Number > 0) { Number = value; } else { throw new ArgumentException("Cant be less null."); } } }
        public virtual object DeepCopy() { return new Edition(this.Title, this.Number); }

        public override bool Equals(object? obj)
        {
            if (obj is null) { return false; }
            if (obj.GetType() != this.GetType()) { return false; }
            Edition other = (Edition)obj;
            return this.Title == other.Title && this.Number == other.Number;
        }

        public override int GetHashCode()
        { return HashCode.Combine(Title, Number); }

        public static bool operator ==(Edition left, Edition right)
        {
            if (left is null) { return right is null; }
            return left.Equals(right);
        }

        public static bool operator !=(Edition left, Edition right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"{Title} by {Number}.\n{Date.ToShortDateString()}";
        }
    }
}
