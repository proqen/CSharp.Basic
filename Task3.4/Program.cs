using System;
using Task3._4.Document;

namespace Task3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Key: ");
            var key = Console.ReadLine();

            DocumentWorker documentWorker = key switch
            {
                "pro" => new ProDocumentWorker(),
                "exp" => new ExpertDocumentWorker(),
                _ => new DocumentWorker()
            };

            documentWorker.OpenDocument();
            documentWorker.EditDocument();
            documentWorker.SaveDocument();
        }
    }
}
