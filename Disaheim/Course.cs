﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim
{
    public class Course
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int durationInMinutes;

        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set { durationInMinutes = value; }
        }

        public Course(string name)
        {
            this.name = name;
        }
        public Course(string name, int durationInMinutes): this(name)
        {
            this.durationInMinutes = durationInMinutes;

        }
        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {durationInMinutes}";
        }

    }
}
