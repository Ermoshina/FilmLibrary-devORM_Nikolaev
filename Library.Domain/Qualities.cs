using System;
using System.Collections.Generic;
using System.Text;
using Movies.Domain;

namespace Movies.Domain
{
    public class Qualitie
    {
        public Qualitie() { }

        public Qualitie(string name)
        {
            this.Title = name;
        }

        public virtual int Id { get; protected set; }

        public virtual string Title { get; protected set; }

        public virtual ISet<Movie> Movies { get; protected set; } = new HashSet<Movie>();

        public override string ToString() => Title;
    }
}
