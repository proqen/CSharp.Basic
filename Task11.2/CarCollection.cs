using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11._2
{
    interface ICarCollection<T> where T : class
    {
        void Add(T ob);
        T this[int index] { get; }
        int Count();
        void AllDelete();
        T[] GetAll();
    }
    class CarCollection : ICarCollection<Car>
    {
        private Car[] cars = new Car[0];
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

        public int Count()
        {
            return cars.Length;
        }

        public Car[] GetAll()
        {
            return cars;
        }
    }
}
