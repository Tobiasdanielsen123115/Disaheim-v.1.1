using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Book
    {
        private string itemId;
        public string ItemId { get; set; }

        private string title;
        public string Title { get; set; }

        private double price;

        public double Price { get; set; }

        public Book(string itemId)
        {
            this.itemId = itemId;
        }
        public Book(string itemId, string title): this(itemId)
        {
            
            this.title = title;

        }
        public Book(string itemId, string title, double price): this(itemId, title)
        {
            
            this.price = price;
        }
        public override string ToString()
        {
            return "ItemId: " + itemId + "," + " Title: " + title + ", " + "Price: " + price;
        }

    }
}
