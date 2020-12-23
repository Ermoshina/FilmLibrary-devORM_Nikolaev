namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    public class QualityMap : ClassMap<Qualitie>
    {
        public QualityMap()
        {
            this.Table("Qualities");

            this.Id(x => x.Id);

            this.Map(x => x.Title).Column("quality");

            this.HasMany(x => x.Movies);
        }
    }
}
