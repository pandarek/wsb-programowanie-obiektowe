using System;
namespace MusicPlayer
{
    public class Electro : Song
    {
        private string _genre;
        private string _title;
        private string _artist;

        public Electro(string Artist, string Title, string Genre = "Electro") : base(Artist, Title)
        {
            this._genre = Genre;
            this._title = Title;
            this._artist = Artist;
        }

        public override string Play()
        {
            return base.Play() + $", Gatunek: {_genre}";
        }
    }
}