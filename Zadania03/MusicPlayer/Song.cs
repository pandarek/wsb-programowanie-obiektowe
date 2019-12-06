using System;
using System.Collections.Generic;

namespace MusicPlayer
{
    public class Song
    {
        private string _title;
        private string _artist;

        public Song(string Title, string Artist)
        {
            this._artist = Artist;
            this._title = Title;  
        }
     
        public string Title { get; set; }
        public string Artist { get; set; }

        public string Play()
        {
            return $"Tytuł: {_title}, Artysta: {_artist}";
        }

        public override string ToString()
        {
            return $"Tytuł: {_title}, Artysta: {_artist}";
        }
    }
}