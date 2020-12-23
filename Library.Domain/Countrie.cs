using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Domain
{
    public class Countrie
    {
        public Countrie() { }

        public Countrie(string name)
        {
            this.Name = name;
        }

        //public Countrie(string name, Movie film, Actor actor)
        //{
        //    this.Name = name;
        //    this.Movies = (ISet<Movie>)film;
        //    this.Actors = (ISet<Actor>)actor;
        //}

        //public Countrie(Movie film) { this.Movies = (ISet<Movie>) film; }

        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Movie> Movies { get; protected set; } = new HashSet<Movie>();

        public virtual ISet<Actor> Actors { get; protected set; } = new HashSet<Actor>();

        public override string ToString() => Name;
    }
}
