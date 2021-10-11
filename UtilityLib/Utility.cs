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
            switch (amulet.Quality)//if else er bedre 
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
        public double GetValueOfCourse(Course course)//vi skal finde prisen for hver pågyndt time
        {
            int CourseHoursStarted;
            CourseHoursStarted = course.DurationInMinutes / 60; // duration in minutes ( er nu delt med 60 så der er 60 minutter på en time) vi siger 1 min er = 1 time

            int CoursePrice = CourseHoursStarted * 875; // Hver time stiger prisen med 875 

            if (course.DurationInMinutes % 60 > 0) // hvis der er noget i rest, så kommer der 875 i pris 
                // eksempel 120 % 60 = 0 så nul i rest men hvis den > end 0 så courseprice + 875 
            {
                CoursePrice = CoursePrice + 875;
            }

            return CoursePrice;
        }   

    }
}
