using System;
namespace MusicPlayer
{
    public class HardCore : Song
    {
        private string _genre;
        private string _title;
        private string _artist;

        public HardCore(string Genre, string Title, string Artist) : base(Title, Artist)
        {
            this._genre = Genre;
            this._title = Title;
            this._artist = Artist;
        }

        new public string Play()
        {
            return base.Play() + $"Gatunek: {_genre}";
        }
    }
}
