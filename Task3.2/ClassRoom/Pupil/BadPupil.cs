using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class BadPupil : Pupil
    {
        public BadPupil()
        {
            Name = "BadPupil";
            Study = "39";
            Read = "50";
            Write = "60";
            Relax = "99";
        }
    }
}
