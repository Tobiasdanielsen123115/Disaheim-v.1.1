using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Utility
    {
        private double lowQualityValue = 12.5;
        public double LowQualityValue
        {
            get { return lowQualityValue; }
            set { lowQualityValue = value; }
        }

        private double mediumQualityValue = 20;
        public double MediumQualityValue
        {
            get { return mediumQualityValue; }
            set { mediumQualityValue = value; }
        }
       
        private double highQualityValue = 27.5;
        public double HighQualityValue
        {
            get { return highQualityValue ; }
            set { highQualityValue  = value; }
        }
        private double courseHourValue = 875;

        public double CourseHourValue
        {
            get { return courseHourValue; }
            set { courseHourValue = value; }
        }




        //public double GetValueOfBook(Book book) // skal ikke bruges mere da merchandise nederst dækker det her nu! 
        //{

        //     return book.Price;

        //}
        // public double GetValueOfAmulet(Amulet amulet)
        // {
        //     switch (amulet.Quality)//if else er bedre 
        //     {

        //         case Level.low:
        //             return 12.5;
        //         case Level.medium:
        //             return 20;
        //         case Level.high:
        //             return 27.5;

        //     }
        //     return 0;


        // }


        public double GetValueOfCourse(Course course)//vi skal finde prisen for hver pågyndt time
        {
            double CourseHoursStarted;
            CourseHoursStarted = course.DurationInMinutes / 60; // duration in minutes ( er nu delt med 60 så der er 60 minutter på en time) vi siger 1 min er = 1 time

            double CoursePrice = CourseHoursStarted * 875; // Hver time stiger prisen med 875 

            if (course.DurationInMinutes % 60 > 0) // hvis der er noget i rest, så kommer der 875 i pris 
                // eksempel 120 % 60 = 0 så nul i rest men hvis den > end 0 så courseprice + 875 
            {
                CoursePrice = CoursePrice + CourseHourValue;
            }

            return CoursePrice;
        }   
        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            double result = 0;
            if(merchandise is Book book)
            {

                result = book.Price;
                
            }
            
            if (merchandise is Amulet amulet)
            {
                if(amulet.Quality == Level.low)
                {
                    result = LowQualityValue;
                }
                if(amulet.Quality == Level.medium)
                {
                    result = MediumQualityValue;
                }
                if (amulet.Quality == Level.high)
                {
                    result = HighQualityValue;
                }


            } return result;
            
        }

    }
}
