using System;
using System.Collections.Generic;
using System.Text;
//@author Ansari Mohammed Faisal - 000812671

namespace Lab3A
{
    public class Song : Media
    {
        string artist,album;
        /// <summary>
        /// this Constructor intializes all variabels
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="artist"></param>
        /// <param name="album"></param>
        public Song(string title, int year,string artist,string album) : base(title, year)
        {
            this.Title = title;
            this.Year = year;
            this.artist = artist;
            this.album = album;
        }
     

        /// <summary>
        /// 
        /// </summary>
        /// <returns>returns Title,year,album and artist</returns>
        public override string ToString()
        {
            return ($"Song Title: {Title} ({Year}) \nAlbum: {album}    Artist: {artist}\n----------------------");

        }
    }
}
