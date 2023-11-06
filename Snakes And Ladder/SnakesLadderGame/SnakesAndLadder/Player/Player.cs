
namespace SnakesLadderGame.SnakesAndLadder.Player
{
    public class Player
    {
        private string Name;
        private int Position;

        public Player(int name)
        {
            Name = name.ToString();
            Position = 0;
        }
        public int GetPosition()
        {
            return Position;
        }

        public void SetPosition(int newPosition)
        {
            Position = newPosition;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
