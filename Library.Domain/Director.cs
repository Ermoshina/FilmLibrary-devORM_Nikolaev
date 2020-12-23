using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Domain
{
    public class Director
    {
        public Director()
        {
        }

        public Director(string name)
        {
            this.Name = name;
        }

        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual ISet<Movie> Movie { get; protected set; } = new HashSet<Movie>();

        public override string ToString() => Name;

    }
}
