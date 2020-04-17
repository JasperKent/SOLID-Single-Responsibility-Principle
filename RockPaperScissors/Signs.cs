namespace RockPaperScissors
{
    public enum Sign { Rock, Paper, Scissors, Lizard, Spock }

    public static class Signs
    {
        static readonly private bool?[,] _beats;

        public static bool? Beats(Sign s1, Sign s2) => _beats[(int)s1, (int)s2];

        public static int Count => (int)Sign.Spock + 1;

        static Signs()
        {
                                  //             Rock,  Paper, Scissors, Lizard, Spock        
            _beats = new bool?[,] /*Rock*/    {{ null,  false, true,     true,   false },  
                                  /*Paper*/    { true,  null,  false,    false,  true }, 
                                  /*Scissors*/ { false, true,  null,     true,   false },
                                  /*Lizard*/   { false, true,  false,    null,   true },
                                  /*Spock*/    { true,  false, true,     false,  null }};
        }
    }
}
