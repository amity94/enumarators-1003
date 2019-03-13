using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1003
{
    class Magician : IComparable<Magician>, INameable
    {
        public string Name { get; private set; }
        public string BirthTown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public Magician(string name, string birthTown, string favoriteSpell)
        {
            this.Name = name;
            this.BirthTown = birthTown;
            this.FavoriteSpell = favoriteSpell;
        }
        public string this[string fieldName]
        {
            get
            {
                switch (fieldName)
                {
                    case "Name":
                        return this.Name;
                    case "BirthTown":
                        return this.BirthTown;
                    case "FavoriteSpell":
                        return this.FavoriteSpell;
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
                    case "FavoriteSpell":
                        this.FavoriteSpell = value;
                        break;
                }
            }
        }
        public override string ToString()
        {
            return $"Magician:{Name}, From: {BirthTown}, Favorite Spell: {FavoriteSpell}";
        }

        public int CompareTo(Magician other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
