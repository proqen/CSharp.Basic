using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    class MyList<T>
    {
        T[] variable = new T[0];
        public IEnumerator<T> GetEnumerator()
        {
            return new MyListEnumerator<T>(variable);
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
            Array.Resize(ref variable, variable.Length + 1);
            variable[^1] = item;
        }

        public T[] Get()
        {
            return variable;
        }
        public int Count
        {
            get
            {
                return variable.Length;
            }
        }
    }
    class MyListEnumerator<T> :  IEnumerator<T>
    {
        private T[] variable;

        int position = -1;
        public MyListEnumerator(T[] variable)
        {
            this.variable = variable;
        }

        public T Current
        {
            get
            {
                if (position == -1 || position >= variable.Length)
                    throw new InvalidOperationException();
                return variable[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            if (position < variable.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            
        }
    }
}
