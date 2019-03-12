using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1003
{
    class Magician
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
        public string this[string name]
        {
            get
            {
                if (name == "Name")
                {
                    return Name;
                }
                if (name == "BirthTown")
                {
                    return BirthTown;
                }
                if (name == "FavoriteSpell")
                {
                    return FavoriteSpell;
                }
                return "Unknown";
            }
        }
        public override string ToString()
        {
            return $"Magician:{Name}, From: {BirthTown}, Favorite Spell: {FavoriteSpell}";
        }
    }
}
