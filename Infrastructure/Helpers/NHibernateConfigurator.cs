namespace Infrastructure.Helpers
{
    using System.Reflection;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;

    public static class NHibernateConfigurator
    {
        public static string DataSourceLocation = @"DESKTOP-RLC90KL\SQLEXPRESS";

        private static string GetConnectionString() => @"Data Source=DESKTOP-RLC90KL\SQLEXPRESS; Initial Catalog = FilmLabDB; Integrated Security = True";

        private static FluentConfiguration config;

        public static FluentConfiguration GetConfiguration(Assembly assembly, bool showSql = false)
        {
            var configuration = MsSqlConfiguration.MsSql2012.ConnectionString(GetConnectionString());

            if (showSql)
            {
                configuration = configuration.ShowSql().FormatSql();
            }

            return config = Fluently.Configure()
                .Database(configuration)
                .Mappings(m => m
                    .FluentMappings.AddFromAssembly(assembly)
                    .Conventions.AddAssembly(Assembly.GetExecutingAssembly()));
        }

        public static ISessionFactory GetSessionFactory() => config?.BuildSessionFactory();
    }
}
