using System;
namespace MusicPlayer
{
    public class Rock : Song
    {
        private string _genre;
        private string _title;
        private string _artist;

        public Rock(string Title, string Artist, string Genre = "Rock") : base(Title, Artist)
        {
            this.Title = Title;
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