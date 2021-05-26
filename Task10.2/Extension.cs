using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10._2
{
    //Task 10.4
    static class Extension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.Get();
        }
    }
}
