namespace Movies.Domain
{
    using Infrastructure.Extensions;
    public class Movie
    {
        public Movie() { }

        public Movie(string name)
        {
            this.Name = name;
        }

        public Movie(string name, Actor actor, Countrie  country)
        {
            this.Name = name;
            this.Actor = actor;
            this.Countrie = country;
        }


        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }

        public virtual int Year { get; protected set; }

        public virtual Director Director { get; protected set; }

        public virtual Genre Genre { get; protected set; }

        public virtual Countrie Countrie { get; protected set; }

        public virtual Qualitie Qualitie { get; protected set; }

        public virtual Actor Actor { get; protected set; }

        public virtual MediaFormat MediaFormat { get; protected set; }

        //public virtual Sale Sale { get; protected set; }

        public virtual string Description { get; protected set; }

        public override string ToString() => $"Название фильма: {this.Name}\n\tГод выхода на экраны: {this.Year}\n\tРежисёр: {this.Director}\n\tЖанр: {this.Genre}\n\tСтрана: {this.Countrie}\n\tКачество: {this.Qualitie}\n\tАктеры: {this.Actor}\n\tФормат: {this.MediaFormat}\n\tОписание: {this.Description}\n\n";
    }
}
