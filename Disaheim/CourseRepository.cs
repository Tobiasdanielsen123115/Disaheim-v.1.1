using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses;
        Utility utility = new Utility();
        public CourseRepository()
        {
            courses = new List<Course>();
        }

        public void AddCourse(Course Course)
        {
            courses.Add(Course);
            
        }
        public Course GetCourse(string name)
        {
            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Name == name)
                {
                    return courses[i];

                }

            }
            return null;


        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            for (int i = 0; i < courses.Count; i++)
            {
                totalValue += utility.GetValueOfCourse(courses[i]);
            }
            return totalValue;
        } 
        


    }
}
