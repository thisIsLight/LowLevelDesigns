using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadderGame.SnakesAndLadder.CellElements
{
    public class SnakeCell : ICell
    {
        private int CellBehaviorPosition;

        public SnakeCell(int cellBehaviourPosition)
        {
            CellBehaviorPosition = cellBehaviourPosition;
        }

        public int GetFinalPosition()
        {
            Console.WriteLine("  /");
            Console.WriteLine("(..)");
            Console.WriteLine("{}");
            Console.WriteLine(" {}");
            Console.WriteLine("{}");
            Console.WriteLine(" {}");
            Console.WriteLine(" /");
            return CellBehaviorPosition;
        }
    }
}
