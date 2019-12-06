using System;
namespace MusicPlayer
{
    public class Rock : Song
    {
        private string _genre;
        private string _title;
        private string _artist;

        public Rock(string Artist, string Title, string Genre = "Rock") : base(Artist, Title)
        {
            this.Title = Title;
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