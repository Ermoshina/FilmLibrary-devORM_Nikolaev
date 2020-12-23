namespace Movie.NH.Tests
{
    using Movies.Domain;
    using Infrastructure.Helpers;
    using NHibernate;
    using NUnit.Framework;
    using FluentNHibernate.Testing;
    using Movies.NH.Maps;
    public class DirectorMappingTest
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
            new PersistenceSpecification<Director>(this.session)
                .CheckProperty(x => x.Name, "Гай Ричи")
                //фильмы
                .VerifyTheMappings();
        }
    }
}
