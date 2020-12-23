namespace Movie.NH.Tests
{
    using Movies.Domain;
    using Infrastructure.Helpers;
    using NHibernate;
    using NUnit.Framework;
    using FluentNHibernate.Testing;
    using Movies.NH.Maps;
    public class GenreMappingTest
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
            new PersistenceSpecification<Genre>(this.session)
                .CheckProperty(x => x.Title, "Ужасы")
                //фильмы
                .VerifyTheMappings();
        }
    }
}
