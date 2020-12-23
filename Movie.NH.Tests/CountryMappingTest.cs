namespace Movie.NH.Tests
{
    using Movies.Domain;
    using Infrastructure.Helpers;
    using NHibernate;
    using NUnit.Framework;
    using FluentNHibernate.Testing;
    using Movies.NH.Maps;
    public class CountryMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(ActorMap), typeof(CountrieMap), typeof(MovieMap), typeof(DirectorMap), typeof(GenreMap), typeof(QualityMap), typeof(MediaFormatMap));
        }

        [Test]
        public void CountryMapping_NoNullFields_Success()
        {
            new PersistenceSpecification<Countrie>(this.session)
                .CheckProperty(x => x.Name, "Страна ОЗ")
                //фильмы и актеры
                .VerifyTheMappings();
        }
    }
}
