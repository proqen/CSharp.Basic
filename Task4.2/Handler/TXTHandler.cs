using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2.Handler
{
    class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge TXTHandler");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXTHandler");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXTHandler");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXTHandler");
        }
    }
}
