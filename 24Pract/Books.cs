using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Pract
{
    internal class Books
    {
        public List<string> BooksForReading = new List<string>();

        public void AddBooks()
        {
            Console.Write("Add a new book: ");
            string[] booksToAdd = Console.ReadLine().Split(',');

            foreach (string book in booksToAdd)
            {
                string trimmedBook = book.Trim();
                if (!string.IsNullOrEmpty(trimmedBook) && !BooksForReading.Contains(trimmedBook))
                { BooksForReading.Add(trimmedBook); }
            }

            DisplayBooks("\t--List of the books--");
        }

        public void DeleteBooks()
        {
            Console.Write("Delete a book (you can delete multiple books separated by commas): ");
            string[] booksToDelete = Console.ReadLine().Split(',');

            foreach (string book in booksToDelete)
            {
                string trimmedBook = book.Trim();

                if (BooksForReading.Contains(trimmedBook))
                { BooksForReading.Remove(trimmedBook); }
                else
                { Console.WriteLine($"Book '{trimmedBook}' not found in the list.");}
            }

            DisplayBooks("\t--List of the books after deletion--");
        }

        public void CheckBooks()
        {
            Console.Write("Which book do you want to find?\nAnswer: ");
            string bookToFind = Console.ReadLine().Trim();

            if (BooksForReading.Contains(bookToFind))
            {Console.WriteLine("Find it!"); }
            else
            { Console.WriteLine("Not found it. You should add this book."); }
        }

        private void DisplayBooks(string title)
        {
            Console.WriteLine(title);
            foreach (string book in BooksForReading)
            { Console.WriteLine("\t" + book);}
        }
    }
}
