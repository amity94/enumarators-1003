using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1003
{
    class Knight
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

        public string this[string name]
        {
            get
            {
                if(name == "Name")
                {
                    return Name;
                }
                if (name == "BirthTown")
                {
                    return BirthTown;
                }
                if (name == "Title")
                {
                    return Title;
                }
                return "Unknown";
            }
        }

        public override string ToString()
        {
            return $"Knight: {Name}, From: {BirthTown}, Title: {Title}";
        }
    }
}
