using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Assesment_Start
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ReleaseDate { get; set;  }
        public string Genre { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int CopiesSold { get; set; }

        public Book(string title, string author, int releaseDate, string genre, double price, int stock, int copiesSold)
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
            Genre = genre;
            Price = price;
            Stock = stock;
            CopiesSold = copiesSold;
        }
    }
}