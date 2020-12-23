namespace Movies.NH.Maps
{
    using FluentNHibernate.Mapping;
    using Movies.Domain;

    public class MovieMap : ClassMap<Movie>
    {
        public MovieMap()
        {
            this.Table("Movies");

            this.Id(x => x.Id);

            this.Map(x => x.Name).Column("movie_name");

            this.Map(x => x.Year).Column("issue_year");

            this.Map(x => x.Description);

            this.References(x => x.Director).Column("director_id");

            this.References(x => x.Genre).Column("genre_id");

            this.References(x => x.Countrie).Column("country_id");

            this.References(x => x.Qualitie).Column("quality_id");

            this.References(x => x.Actor).Column("actor_id").Cascade.SaveUpdate();

            this.References(x => x.MediaFormat).Column("format_id");

            //this.References(x => x.Sale).Column("Id");
        }
    }
}
