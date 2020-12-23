namespace Movies.NH
{
    using Movies.Domain;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Правила отображения для <see cref="Name"/>.
    /// </summary>
    internal class NameMap : ComponentMap<Name>
    {
        public NameMap()
        {
            this.Map(x => x.SecondName);
            this.Map(x => x.FirstName);
            this.Map(x => x.MiddleName);
        }
    }
}
