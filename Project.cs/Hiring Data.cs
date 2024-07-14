using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_OOP_Assignment
{
    internal class Hiring_Date
    {
       private int year, month, day;

        #region Propertys
        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; } 
        #endregion
        public Hiring_Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
    }
}
