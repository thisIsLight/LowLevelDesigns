using SnakesLadderGame.SnakesAndLadder.Game;

namespace SnakesLadderGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            var game = new SnakesAndLadderGame();

            var winner = game.Play(5);

            Console.WriteLine(winner);
        }
    }
}