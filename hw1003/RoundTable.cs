using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1003
{
    class RoundTable<T> : IEnumerable<T>, IComparable<T>
    {
        private List<T> entities;

        public RoundTable()
        {

        }

        public void Add(T any)
        {
            entities.Add(any);
        }
        
        public void RemoveAt(int any)
        {
            T item = entities[any];
            if (any > entities.Count)
            {
                item = entities[any + 1];
                entities.Remove(item);
            }
            entities.Remove(item);
        }

        public void Clear()
        {
            entities.Clear();
        }

        public void InsertAt(int any, T t)
        {

        }

        public void Sort()
        {

        }

        public List<T> GetRounded(int any)
        {

        }

        public T this [int index]
        {
            get
            {
                return entities[index];
            }
        }

        public T this [string value]
        {
            get
            {
                if(value ==  )
                return T.;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entities.GetEnumerator();
        }

        public int CompareTo(T other)
        {
              
        }
    }
}
