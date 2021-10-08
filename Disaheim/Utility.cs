using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Utility
    {
       public double GetValueOfBook(Book book)
       {
            
            return book.Price;
            
       }
        public double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {

                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20;
                case Level.high:
                    return 27.5;
                    
            }
            return 0;
             
        }
    }
}
