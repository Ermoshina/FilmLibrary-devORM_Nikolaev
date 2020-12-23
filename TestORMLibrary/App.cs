namespace TestORMLibrary
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Movies.Domain;
    using NHibernate;

    class App
    {
        private readonly ISessionFactory sessionFactory;

        public App(ISessionFactory sessionFactory)
        {
            this.sessionFactory = sessionFactory ?? throw new ArgumentNullException(nameof(sessionFactory));
        }

        public async Task Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            using (var session = this.sessionFactory.OpenSession())
            {
                var books = session.Query<Movie>().ToList();
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
            await Task.CompletedTask;
        }
    }
}
