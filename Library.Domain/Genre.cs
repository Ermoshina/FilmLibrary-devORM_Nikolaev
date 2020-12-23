namespace Movies.Domain
{
    using System.Collections.Generic;

    public class Genre
    {
        public Genre() { }

        public Genre(string name)
        {
            this.Title = name;
        }
        public virtual int Id { get; protected set; }

        public virtual string Title { get; protected set; }

        public virtual ISet<Movie> Movies { get; protected set; } = new HashSet<Movie>();

        public override string ToString() => Title;
    }
}
