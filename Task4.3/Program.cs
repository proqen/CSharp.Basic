using System;

namespace Task4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            
            IRecodable record = new Player();
            record.Record();
            record.Pause();
            record.Stop();

            //////////////////////////////////
            Player player1 = new Player();

            IPlayable playable = player1 as IPlayable; //IPlayable playable = player1;
            playable.Play();
            playable.Pause();
            playable.Stop();

            IRecodable recodable = player1 as IRecodable; //IRecodable recodable = player1;
            recodable.Record();
            recodable.Pause();
            recodable.Stop();
        }
    }
}
