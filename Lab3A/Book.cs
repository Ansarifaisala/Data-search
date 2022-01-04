using System;
using System.Collections.Generic;
using System.Text;
//@author Ansari Mohammed Faisal - 000812671

namespace Lab3A 
{
    public class Book : Media
    {
        string author;

        /// <summary>
        /// this constructor intializes all variables
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="author"></param>
        /// <param name="type"></param>
        public Book(string title, int year, string author) : base(title, year)
        {
            this.Title = title;
            this.Year = year;
            this.author = author;
        }
        /// <summary>
        /// tostring method for books
        /// </summary>
        /// <returns>Returns title,year and author name </returns>
        public override string ToString()
        {
            return ($"Book Title: {Title} ({Year}) \nAuthor: {author}\n----------------------");

        }

    }
}
