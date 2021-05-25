using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2.Handler
{
    class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge XMLHandler");
        }

        public override void Create()
        {
            Console.WriteLine("Create XMLHandler");
        }

        public override void Open()
        {
            Console.WriteLine("Open XMLHandler");
        }

        public override void Save()
        {
            Console.WriteLine("Save XMLHandler");
        }
    }
}
