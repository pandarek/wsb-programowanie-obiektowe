using System;
using System.Collections.Generic;

namespace MusicPlayer
{
    public class Song
    {
        private string _title;
        private string _artist;

        public Song(string Artist, string Title)
        {
            this._artist = Artist;
            this._title = Title;  
        }
     
        public string Title { get; set; }
        public string Artist { get; set; }

        public virtual string Play()
        {
            return $"Tytuł: {_title}, Artysta: {_artist}";
        }
    }
}