using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Assesment_Start
{
    public class Order
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        public string Title => Book.Title;
        public double Price => Book.Price;
        public double Total => Book.Price * Quantity;

        public Order(Book book, int quantity)
        {
            Book = book;
            Quantity = quantity;
        }        
    }
}
