using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Domain
{
    public class Sale
    {
        public virtual int Id { get; protected set; }

        public virtual int IdMovie { get; protected set; }

        public virtual DateTime SaleDate { get; protected set; }

        public virtual int Price { get; protected set; }

        public virtual ISet<Movie> Movies { get; protected set; } = new HashSet<Movie>();
    }
}
