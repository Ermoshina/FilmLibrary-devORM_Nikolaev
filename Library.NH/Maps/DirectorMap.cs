namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;
    public class DirectorMap : ClassMap<Director>
    {
        public DirectorMap()
        {
            this.Table("Directors");

            this.Id(x => x.Id);

            this.Map(x => x.Name).Column("director");

            this.HasMany(x => x.Movie);
        }
    }
}
