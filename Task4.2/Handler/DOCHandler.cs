using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2.Handler
{
    class DOCHandler: AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge DOCHandler");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOCHandler");
        }

        public override void Open()
        {
            Console.WriteLine("Open DOCHandler");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOCHandler");
        }
    }
}
