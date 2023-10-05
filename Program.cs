using System;
using System.Threading;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.Start();

            Console.WriteLine("Dzięki za grę!");
        }
    }
}
