using System.Collections.Generic;
using System.Linq;
using CSharpFunctionalExtensions;
using Logic.Utils;
using NHibernate;
using NHibernate.Linq;

namespace Logic.Movies
{
    public class MovieRepository
    {
        public Maybe<Movie> GetOne(long id)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Get<Movie>(id);
            }
        }

        public IReadOnlyList<MovieDto> GetList(
            Specification<Movie> specification,
            double minimumRating,
            int page = 0,
            int pageSize = 20)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                return session.Query<Movie>()
                    .Where(specification.ToExpression())
                    .Where(x => x.Rating >= minimumRating)
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .Fetch(x => x.Director)
                    .ToList()
                    .Select(x => new MovieDto
                    {
                        Name = x.Name,
                        Director = x.Director.Name,
                        Genre = x.Genre,
                        Id = x.Id,
                        MpaaRating = x.MpaaRating.ToString(),
                        Rating = x.Rating,
                        ReleaseDate = x.ReleaseDate
                    })
                    .ToList();
            }
        }
    }
}
