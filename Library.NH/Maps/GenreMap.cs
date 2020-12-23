namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            this.Table("Genres");

            this.Id(x => x.Id);

            this.Map(x => x.Title).Column("genre");

            this.HasMany(x => x.Movies);
        }
    }
}
