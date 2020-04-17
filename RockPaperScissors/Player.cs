using System;

namespace RockPaperScissors
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; set; }
        public Sign Sign { get; private set; }

        private readonly static Random _random = new Random();

        public Player(string name) => Name = name;

        public void Throw()
        {
            Sign = (Sign)_random.Next(Signs.Count);
        }
    }
}
