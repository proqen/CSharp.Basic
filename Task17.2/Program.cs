using System;
using System.Linq;
using System.Collections.Generic;

namespace Task17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new();

            cars.Add(new Car { Id = 1, Brand = "Mersedes", Model = "S class", Year = "2020", Color = "Black" });
            cars.Add(new Car { Id = 2, Brand = "Tesla", Model = "Model S", Year = "2020", Color = "Red" });
            cars.Add(new Car { Id = 3, Brand = "Honda", Model = "FIT", Year = "2020", Color = "White"});

            List<Client> clients = new();

            clients.Add(new Client { Id = 1, CarId = 1, Name = "Kamchybek", PhoneNumber = "996996996996"});
            clients.Add(new Client { Id = 2, CarId = 2, Name = "Kamchy", PhoneNumber = "996996996996"});
            clients.Add(new Client { Id = 3, CarId = 3, Name = "Kam4bIbek", PhoneNumber = "996996996996"});

            var res1 = clients.Select(cl => new 
            {
                Name = cl.Name,
                Phone = cl.PhoneNumber,
                Car = cars.FirstOrDefault(cr => cr.Id == cl.CarId)
            }).First();

            var res2 = clients.Join(cars,cl => cl.Id, cr => cr.Id, (cl,cr) => new
            {
                Name = cl.Name,
                Phone = cl.PhoneNumber,
                Car = cr
            }).First();

            var query = from client in clients
                        join car in cars on client.CarId equals car.Id
                        select new
                        {
                            Name = client.Name,
                            Phone = client.PhoneNumber,
                            Car = car
                        };

            Console.WriteLine($"Name = {res1.Name}, Phone = {res1.Phone}, " +
                $"Brand = {res1.Car.Brand}, Model = {res1.Car.Model}, Year = {res1.Car.Year}, Color = {res1.Car.Color}");
            
            Console.WriteLine($"Name = {res2.Name}, Phone = {res2.Phone}, " +
                $"Brand = {res2.Car.Brand}, Model = {res2.Car.Model}, Year = {res2.Car.Year}, Color = {res2.Car.Color}");

            var res3 = query.First();
            Console.WriteLine($"Name = {res3.Name}, Phone = {res3.Phone}, " +
                $"Brand = {res3.Car.Brand}, Model = {res3.Car.Model}, Year = {res3.Car.Year}, Color = {res3.Car.Color}");
        }
    }
}
