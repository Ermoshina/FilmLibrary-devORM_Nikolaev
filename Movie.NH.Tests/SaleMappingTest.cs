using System;

namespace Movie.NH.Tests
{
    using Movies.Domain;
    using Infrastructure.Helpers;
    using NHibernate;
    using NUnit.Framework;
    using FluentNHibernate.Testing;
    using Movies.NH.Maps;
    public class SaleMappingTest
    {
        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true, typeof(ActorMap), typeof(SaleMap), typeof(CountrieMap), typeof(MovieMap), typeof(DirectorMap), typeof(GenreMap), typeof(QualityMap), typeof(MediaFormatMap));
        }

        [Test]
        public void ActorMapping_NoNullFields_Success()
        {
            new PersistenceSpecification<Sale>(this.session)
                .CheckProperty(x => x.IdMovie, 1)
                .CheckProperty(x => x.Price, 900)
                .CheckProperty(x => x.SaleDate, new DateTime(2019, 12, 31))
                //фильмы
                .VerifyTheMappings();
        }
    }
}
