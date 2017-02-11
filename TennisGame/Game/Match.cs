namespace Game
{
    public class Match
    {
        public Player Player1;
        public Player Player2;
        public Score Points;

        public Match(string pl1, string pl2)
        {
            Player1 = new Player(pl1);
            Player2 = new Player(pl2);
            Points = new Score();
        }
    }
}
