using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Book
    {
        private string title;
        private string author;
        private string publisher;
        private int availableCopies;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int AvailableCopies
        {
            get { return availableCopies; }
            set { availableCopies = value; }
        }

        public Book(string title, string author, string publisher, int availableCopies)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            AvailableCopies = availableCopies;
        }

        public void IncreaseCopies(int count)
        {
            AvailableCopies += count;
        }

        public void DecreaseCopies(int count)
        {
            if (AvailableCopies >= count)
            {
                AvailableCopies -= count;
            }
            else
            {
                Console.WriteLine("Nusxe kifayet qeder deyil.");
            }
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Available Copies: {AvailableCopies}");
        }
    }

}

