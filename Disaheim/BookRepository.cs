using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class BookRepository
    {
        
        private List<Book> books;
        Utility utility = new Utility();
        public BookRepository()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            
        }

        public Book GetBook(string itemId)
        {
            for (int i = 0; i < books.Count; i++)//checker alle vores "skabe" indtil den finder det itemId vi leder efter.
            {
                if (books[i].ItemId == itemId)
                {
                    return books[i]; 

                }
                
            }
            return null;         

           
        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            for (int i = 0; i < books.Count; i++)
            {
                totalValue += books[i].Price;  

            }
            return totalValue;

        }


    }
}
