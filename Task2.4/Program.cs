using System;

namespace Task2._4
{
    class Invoice
    {
        public int account { get; init; }
        public string customer { get; init; }
        public string provider { get; init; }
        private string article { get; set; } = "Apple";
        private int quantity { get; set; } = 6;
        private int price { get; set; } = 3;
        private double NDS { get; set; } = 20; // 20%

        public void Calculation()
        {
            Console.WriteLine($"Account: {account}");
            Console.WriteLine($"Customer: {customer}");
            Console.WriteLine($"Provider: {provider}");
            Console.WriteLine($"Article: {article}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Total payment amount: {price * quantity}");
        }
        public void CalculationNDS()
        {
            Console.WriteLine($"Account: {account}");
            Console.WriteLine($"Customer: {customer}");
            Console.WriteLine($"Provider: {provider}");
            Console.WriteLine($"Article: {article}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Total payment amount: {(price * quantity) * (1+(NDS/100))}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice() 
            { 
                account = 123, 
                customer = "Kamchybek",
                provider = "Aman"
            };
            invoice.Calculation();
            Console.WriteLine("__________NDS_________");
            invoice.CalculationNDS();
        }
    }
}
