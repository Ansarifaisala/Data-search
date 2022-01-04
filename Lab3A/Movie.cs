using System;
using System.Collections.Generic;
using System.Text;
//@author Ansari Mohammed Faisal - 000812671

namespace Lab3A
{
    public class Movie : Media
    {
        string director;
        /// <summary>
        /// this constructor intializes all variabes
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="director"></param>
        public Movie(string title, int year,string director) : base(title, year)
        {
            this.Title = title;
            this.Year = year;
            this.director = director;
        }
   
        /// <summary>
        /// 
        /// </summary>
        /// <returns>returns Title,year and director</returns>
        public override string ToString()
        {
            return ($"Movie Title: {Title} ({Year}) \nDirector: {director}\n----------------------");

        }
    }
}
