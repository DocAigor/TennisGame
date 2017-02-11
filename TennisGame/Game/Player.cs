namespace Game
{
    public class Player
    {
        public string PlayerName;
        public int Points;


        public Player(string name)
        {
            PlayerName = name;
        }

        public void AddPoint()
        {
            Points++;
        }
    }
}
