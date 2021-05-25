using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class ClassRoom
    {
        private readonly List<Pupil> Pupils;

        public ClassRoom(List<Pupil> Pupils)
        {
            this.Pupils = Pupils;
        }

        public void PipulsInfo()
        {
            foreach (var item in Pupils)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Study: {item.Study}");
                Console.WriteLine($"Read: {item.Read}");
                Console.WriteLine($"Write: {item.Write}");
                Console.WriteLine($"Relax: {item.Relax}");
            }
        }
    }
}
