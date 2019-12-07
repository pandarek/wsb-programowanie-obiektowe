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
            Console.WriteLine($"\nUtwór dodany...\n");
           
        }

        public void Remove(int songNumber)
        {
            playlist.RemoveAt(songNumber);
            Console.WriteLine("Utwór usunięty...\n");
        }

        public void Play(int songNumber)
        {
            Console.WriteLine(playlist[songNumber].Play());
            Helper.PlayAnim();
        }
    }
}