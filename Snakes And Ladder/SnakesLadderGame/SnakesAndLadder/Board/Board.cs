using SnakesLadderGame.SnakesAndLadder.CellElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadderGame.SnakesAndLadder.Board
{
    public class Board
    {
        private readonly List<ICell> cells;

        public Board()
        {
            cells = new List<ICell>();
            for(var i = 0; i < 100; i++)
            {
                if(i%10 == 0)
                {
                    cells.Add(new LadderCell(i+5));
                }
                else if(i%15 == 0)
                {
                    cells.Add(new SnakeCell(i - 10));
                }
                else
                {
                    cells.Add(new NeutralCell(i));
                }
            }
        }

        public int GetNewPosition(int currentPlayerPosition, int scoreFromDice)
        {
            var newPosition = currentPlayerPosition + scoreFromDice;
            if(newPosition >= 100)
            {
                return currentPlayerPosition;
            }
            else
            {
                return cells[newPosition].GetFinalPosition();
            }
        }
    }
}
