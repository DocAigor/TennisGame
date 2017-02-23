using System;
namespace Game
{
    public class Match
    {
        /// <summary>
        /// Player 1
        /// </summary>
        public Player Player1;
        /// <summary>
        /// Player 2
        /// </summary>
        public Player Player2;
        /// <summary>
        /// Score 
        /// </summary>
        private Score points;


        public Match(string pl1, string pl2)
        {
            Player1 = new Player(pl1);
            Player2 = new Player(pl2);
            points = new Score();
        }

        /// <summary>
        /// Chiama il calcolo dello Score
        /// </summary>
        /// <returns>Restituisce il risultato</returns>
        public Tuple<string,string> GetScore()
        {
            return points.GetResult(Player1.GetPoints(), Player2.GetPoints());
        }
    }
}
