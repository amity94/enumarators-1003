using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1003
{
    class Knight : IComparable<Knight>, INameable
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthTown, string title)
        {
            this.Name = name;
            this.BirthTown = birthTown;
            this.Title = title;
        }

        public string this[string fieldName]
        {
            get
            {
                switch(fieldName)
                {
                    case "Name":
                        return this.Name;
                    case "BirthTown":
                        return this.BirthTown;
                    case "Title":
                        return this.Title;
                }
                return null;
            }
            set
            {
                switch (fieldName)
                {
                    case "Name":
                        this.Name = value;
                        break;
                    case "BirthTown":
                        this.BirthTown = value;
                        break;
                    case "Title":
                        this.Title = value;
                        break;
                }
            }
        }

        public override string ToString()
        {
            return $"Knight: {Name}, From: {BirthTown}, Title: {Title}";
        }

        public int CompareTo(Knight other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
