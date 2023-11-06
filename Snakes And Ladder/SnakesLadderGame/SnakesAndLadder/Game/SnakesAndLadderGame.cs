using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakesLadderGame.SnakesAndLadder.Board;
using SnakesLadderGame.SnakesAndLadder.Dice;
using SnakesLadderGame.SnakesAndLadder.Player;

namespace SnakesLadderGame.SnakesAndLadder.Game
{
    public class SnakesAndLadderGame : IGame
    {
        private Board.Board board;
        private Dice.Dice dice;
        private List<Player.Player> players = new();

        public string Play(int numberOfPlayers)
        {
            Init(numberOfPlayers);
            if(players.Count <= 0) {
                return "Game requires Minimum of 1 players";
            }
            var currentPlayerIndex = 0;
            while (true)
            {
                var currentPlayer = players[currentPlayerIndex];
                var currentPlayerPosition = currentPlayer.GetPosition();
                var scoreFromDice = dice.GetScore();
                Console.WriteLine($"Player {currentPlayer} played. -->");
                Console.WriteLine($"Last Position was {currentPlayerPosition}        !!");
                Console.WriteLine($"Dice Score was {scoreFromDice}            !!");
                var newPosition = board.GetNewPosition(currentPlayerPosition, scoreFromDice);
                currentPlayer.SetPosition(newPosition);
                Console.WriteLine($"Player reached to {newPosition}        !!");
                Console.WriteLine($"==============================");
                if (newPosition == 99)
                {
                    return $"Winner is Player {currentPlayer}";
                }
                currentPlayerIndex = (currentPlayerIndex+1)%players.Count;
            }
        }

        private void Init(int numberOfPlayers)
        {
            board = new Board.Board();
            dice = new Dice.Dice();
            for(var i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player.Player(i));
            }
        }
    }
}
