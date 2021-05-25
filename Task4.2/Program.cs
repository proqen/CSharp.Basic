using System;
using System.Collections.Generic;
using Task4._2.Handler;

namespace Task4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type: ");
            var type = Console.ReadLine();

            AbstractHandler documentWorker = type switch
            {
                "xml" => new XMLHandler(),
                "doc" => new DOCHandler(),
                "txt" => new TXTHandler(),
                _ => null
            };

            if(documentWorker != null)
            {
                documentWorker.Open();
                documentWorker.Create();
                documentWorker.Chenge();
                documentWorker.Save();
            }

            //XMLHandler xmlHandler = new XMLHandler();
            //DOCHandler docHandler = new DOCHandler();
            //TXTHandler txtHandler = new TXTHandler();

            //foreach (var item in new List<AbstractHandler>() { xmlHandler, docHandler, txtHandler})
            //{
            //    Console.WriteLine();
            //    item.Open();
            //    item.Create();
            //    item.Chenge();
            //    item.Save();
            //}
        }
    }
}
