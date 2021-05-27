using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._2
{
    interface ICarCollection<T> where T : class
    {
        void Add(T ob);
        T this[int index] { get; }
        int Count { get; }
        void AllDelete();
        T[] GetAll();
    }
    class CarCollection : ICarCollection<Car>
    {
        private Car[] cars = new Car[0];

        public IEnumerator<Car> GetEnumerator()
        {
           return new CarEnumerator<Car>(cars); 
        }
        
        public void Add(Car ob)
        {
            Array.Resize(ref cars, cars.Length+1);
            cars[^1] = ob;
        }
        public Car this[int index]
        {
            get
            {
                if (index > -1 && cars.Length > index)
                    return cars[index];
                else
                    throw new InvalidOperationException();
            }
        }

        public void AllDelete()
        {
            cars.DefaultIfEmpty();
        }

        public int Count
        {
            get 
            {
                return cars.Length;
            }
        }

        public Car[] GetAll()
        {
            return cars;
        }
        class CarEnumerator<T> : IEnumerator<T>
        {
            private T[] items;

            int position = -1;
            public CarEnumerator(T[] items)
            {
                this.items = items;
            }

            public T Current
            {
                get
                {
                    if (position == -1 || position >= items.Length)
                        throw new InvalidOperationException();
                    return items[position];
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public bool MoveNext()
            {
                if (position < items.Length - 1)
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
}
