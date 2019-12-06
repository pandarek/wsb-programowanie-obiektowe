using System;
using System.Collections.Generic;

namespace MusicPlayer
{
    public class Player
    {
        
        public List<Song> playlist = new List<Song>();

        public void Add(Song song)
        {
     
            playlist.Add(song);
           
        }

        public void Remove(int songNumber)
        {

        }

        public void Play(int songNumber)
        {

        }
    }
}
