using System;
namespace MusicPlayer
{
    public class HardCore : Song
    {
        private string _genre;
        private string _title;
        private string _artist;

        public HardCore(string Artist, string Title, string Genre = "Hard Core") : base(Artist, Title)
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