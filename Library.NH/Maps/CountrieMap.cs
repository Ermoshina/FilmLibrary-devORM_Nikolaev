namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    public class CountrieMap : ClassMap<Countrie>
    {
        public CountrieMap()
        {
            this.Table("Countries");

            this.Id(x => x.Id);

            this.Map(x => x.Name).Column("country");

            this.HasMany(x => x.Movies);

            this.HasMany(x => x.Actors);

        }
    }
}
