using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecodable
    {
        void IRecodable.Pause()
        {
            Console.WriteLine("Recodable Pause");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Playable Pause");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("Play");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Record");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playable Stop");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Recodable Stop");
        }
    }
}
