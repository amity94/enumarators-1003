using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1003
{
    class RoundTable<T> : IEnumerable<T> where T: IComparable<T>, INameable
    {
        private List<T> entities = new List<T>();

        public RoundTable()
        {

        }

        public void Add(T any)
        {
            entities.Add(any);
        }
        
        public void RemoveAt(int any)
        {
            if (entities.Count == 0)
                return;
            entities.RemoveAt(any % entities.Count);
        }

        public void Clear()
        {
            entities.Clear();
        }

        public void InsertAt(int any, T t)
        {
            entities.Insert(any % entities.Count, t);
        }

        public void Sort()
        {
            entities.Sort();
        }

        public List<T> GetRounded(int any)
        {
            List<T> result = new List<T>();
            int counter = 0;
            int index = 0;
            while(counter++ < any)
            {
                result.Add(entities[index++]);
                if(index>= entities.Count)
                {
                    index = 0;
                }
            }
            return result;
        }

        public T this [int index]
        {
            get
            {
                if (entities.Count == 0)
                return default(T);

                return entities[index % entities.Count];
            }
        }

        public T this [string name]
        {
            get
            {
                if (entities.Count == 0)
                    return default(T);

                foreach (T entity in entities)
                    if (entity.Name == name)
                        return entity;

                return default(T);
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

        
    }
}
