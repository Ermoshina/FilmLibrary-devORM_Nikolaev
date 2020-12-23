using System.Collections.Generic;

namespace Movie.NH.Tests
{
    using Movies.Domain;
    using Infrastructure.Helpers;
    using NHibernate;
    using NUnit.Framework;
    using FluentNHibernate.Testing;
    using Movies.NH.Maps;
    public class ActorMappingTest
    {
        

        private ISession session;

        [SetUp]
        public void Setup()
        {
            this.session = NHibernateTestHelper.GetSession(true,typeof(ActorMap), typeof(CountrieMap), typeof(MovieMap), typeof(DirectorMap), typeof(GenreMap), typeof(QualityMap), typeof(MediaFormatMap));
            
        }

        [Test]
        public void ActorMapping_NoNullFields_Success()
        {
            Countrie TestCountry = new Countrie("Гваделупа");
            //Actor TestActor = new Actor("Александр Петров", TestMovie, TestCountry);
            Movie TestMovie1 = new Movie("Фильм");
            Movie TestMovie2 = new Movie("Gthrhrthrt");
            
            this.session.SaveOrUpdate(TestCountry);
            //this.session.SaveOrUpdate(TestActor);


            new PersistenceSpecification<Actor>(this.session)
                .CheckProperty(x => x.Name, "Александр Петров")
                .CheckReference(x => x.Countrie, TestCountry, c=>c.Id)
                .CheckList(x=>x.Movies, new List<Movie> {TestMovie1, TestMovie2}, c=>c.Id)
                .VerifyTheMappings();
        }
    }
}