using System;


namespace Logic.Movies
{
    public class MovieDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual string MpaaRating { get; set; }
        public virtual string Genre { get; set; }
        public virtual double Rating { get; set; }
        public virtual string Director { get; set; }
    }
}
