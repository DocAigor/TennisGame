namespace Game
{
    /// <summary>
    /// Classe per la gestione del Player
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Nome del player
        /// </summary>
        public string PlayerName;
        /// <summary>
        /// Punteggio numerico
        /// </summary>
        private int points;


        public Player(string name)
        {
            PlayerName = name;
        }
        /// <summary>
        /// Aggiunge un punto
        /// </summary>
        public void AddPoint()
        {
            points++;
        }

        public int GetPoints()
        {
            return points;
        }
    }
}
