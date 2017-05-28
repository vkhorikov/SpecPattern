using FluentNHibernate.Mapping;

namespace Logic.Movies
{
    public class MovieMap : ClassMap<Movie>
    {
        public MovieMap()
        {
            Id(x => x.Id);

            Map(x => x.Name);
            Map(x => x.ReleaseDate);
            Map(x => x.MpaaRating).CustomType<int>();
            Map(x => x.Genre);
            Map(x => x.Rating);

            References(x => x.Director);
        }
    }
}
