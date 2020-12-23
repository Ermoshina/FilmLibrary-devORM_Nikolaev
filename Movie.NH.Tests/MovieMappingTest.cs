namespace Movie.NH.Tests
{
    using Movies.Domain;
    using Infrastructure.Helpers;
    using NHibernate;
    using NUnit.Framework;
    using FluentNHibernate.Testing;
    using Movies.NH.Maps;
    public class MovieMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(ActorMap), typeof(CountrieMap), typeof(MovieMap), typeof(DirectorMap), typeof(GenreMap), typeof(QualityMap), typeof(MediaFormatMap));
        }

        [Test]
        public void ActorMapping_NoNullFields_Success()
        {
            Countrie TestCountry = new Countrie("Эфиопия");
            Actor TestActor = new Actor("Александр Петров");
            Director TestDirector = new Director("Квентин Тарантино");
            Genre TestGenre = new Genre("Боевик");
            Qualitie TestQualitie = new Qualitie("4k");
            MediaFormat TestFormat = new MediaFormat("DVD");

            new PersistenceSpecification<Movie>(this.session/*, new CustomEqualityComparer()*/)
                .CheckProperty(x => x.Name, "Фильм")
                .CheckProperty(x => x.Year, 2020)
                //нужно что-то делать с CustomEqualityComparer 
                .CheckProperty(x=>x.Description, "Описание фильма")
                .CheckReference(x => x.Countrie, TestCountry, c=>c.Id)
                .CheckReference(x => x.Actor, TestActor, c => c.Id)
                .CheckReference(x => x.Director, TestDirector, c => c.Id)
                .CheckReference(x => x.Genre, TestGenre, c => c.Id)
                .CheckReference(x => x.Qualitie, TestQualitie, c => c.Id)
                .CheckReference(x => x.MediaFormat, TestFormat, c => c.Id)
                .VerifyTheMappings();
        }
    }
}
