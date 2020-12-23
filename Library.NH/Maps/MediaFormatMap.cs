namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    public class MediaFormatMap : ClassMap<MediaFormat>
    {
        public MediaFormatMap()
        {
            this.Table("MediaFormats");

            this.Id(x => x.Id);

            this.Map(x => x.Name).Column("media_format");

            this.HasMany(x => x.Movies);
        }

    }
}
