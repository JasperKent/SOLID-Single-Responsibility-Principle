using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many throws? ");

            int count = int.Parse(Console.ReadLine());

            Game game = new Game(new Player("Sally"), new Player("Harry"));

            for (int i = 0; i < count; ++i)
                game.Iterate();
        }
    }
}
