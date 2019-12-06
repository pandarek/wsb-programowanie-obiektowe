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
            Console.WriteLine($"Utwór dodany...");
           
        }

        public void Remove(int songNumber)
        {
            playlist.RemoveAt(songNumber);
            Console.WriteLine("Utwór usunięty...");
        }

        public void Play(int songNumber)
        {
            Console.WriteLine(playlist[songNumber].Play());
        }
    }
}