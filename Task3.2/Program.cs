using System;
using System.Collections.Generic;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom(
                new List<Pupil>
                {
                    new ExcelentPupil(),
                    new GoodPupil(),
                    new BadPupil()
                });
            classRoom.PipulsInfo();
        }
    }
}
