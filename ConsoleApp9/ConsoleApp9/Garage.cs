using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Garage : IEnumerable<Car>
    {
        private List<Car> mygarage = new List<Car>();

        internal Car this[string name]
        {
            get
            {
                foreach(Car item in mygarage)
                {
                    if(item.Name == name)
                    {
                        return item;
                    }
                }
                return null;
            }
        }

        internal Car this [int index]
        {
            get
            {
                if (mygarage.Count < index)
                {
                    return null;
                }
                return mygarage[index];
            }
        }

        public Garage()
        {

        }
            
        public void Add(Car c)
        {
            mygarage.Add(c);
        }

        public void Remove(Car c)
        {
            if(mygarage.Count>0)
            {
                mygarage.Remove(c);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return mygarage.GetEnumerator();
        }
        public IEnumerator<Car> GetEnumerator()
        {
            return mygarage.GetEnumerator();
        }
    }
}
