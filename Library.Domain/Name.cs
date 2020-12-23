namespace Movies.Domain
{
    using System;

    public class Name
    {
        public string FirstName { get; }

        public string SecondName { get; }

        public string MiddleName { get; }


        [Obsolete("For NHibernate only.", true)]

        protected Name()
        {
        }

        private void CheckInputString(string value)
        {
            if (value != null && string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public Name(string firstName, string secondName, string middelName)
        {
            this.CheckInputString(firstName);
            this.FirstName = firstName;

            this.CheckInputString(secondName);
            this.SecondName = secondName;

            this.CheckInputString(middelName);
            this.MiddleName = middelName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.FirstName, this.SecondName, this.MiddleName ?? string.Empty);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return false;
            }

            if (object.ReferenceEquals(obj, this))
            {
                return true;
            }

            return obj is Name other
                && string.Equals(this.FirstName, other.FirstName, StringComparison.InvariantCulture)
                && string.Equals(this.SecondName, other.SecondName, StringComparison.InvariantCulture)
                && string.Equals(this.MiddleName, other.MiddleName, StringComparison.InvariantCulture);
        }

        /// <inheritdoc/>
        public override string ToString() => $"{this.SecondName} {this.FirstName} {this.MiddleName}".Trim();
    }
}
