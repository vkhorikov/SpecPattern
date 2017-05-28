using FluentNHibernate.Mapping;

using Logic.Utils;


namespace Logic.Movies
{
    public class Director : Entity
    {
        public virtual string Name { get; }
    }


    public class DirectorMap : ClassMap<Director>
    {
        public DirectorMap()
        {
            Id(x => x.Id);

            Map(x => x.Name);
        }
    }
}
