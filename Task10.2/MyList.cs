using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    public class MyList<T>
    {
        private T[] variable;

        public MyList()
        {
            variable = new T[0];
        }

        public T this[int index] 
        {
            get 
            {
                if (index > -1 && variable.Length > index)
                    return variable[index];
                else
                    throw new InvalidOperationException();
            }
        }
        public void Add(T item)
        {
            Array.Resize(ref variable,variable.Length+1);
            variable[^1] = item;
        }
        public T[] Get()
        {
            return variable;
        }
        public int Count()
        {
            return variable.Length;
        }
    }
}
