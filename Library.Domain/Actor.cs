using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Domain
{
    public class Actor
    {
        public Actor() { }

        public Actor(string name)
        {
            this.Name = name;
        }

        public Actor(string name, Movie film, Countrie country)
        {
            this.Name = name;
            this.Movies = (ISet<Movie>)film;
            this.Countrie = country;
        }

        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Movie> Movies { get; protected set; } = new HashSet<Movie>();

        public virtual Countrie Countrie { get; protected set; }

        public override string ToString() => $"{Name} из {Countrie}";
    }
}
