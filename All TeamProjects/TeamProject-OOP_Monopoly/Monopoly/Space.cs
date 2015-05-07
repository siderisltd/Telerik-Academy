namespace Monopoly
{
    using System;

    public abstract class Space
    {
        private string name;

        public Space(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Property name cannot be null or empty");
                }

                this.name = Name;
            }
        }
    }
}
