using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadderGame.SnakesAndLadder.CellElements
{
    public class NeutralCell : ICell
    {
        private int CellBehaviorPosition;

        public NeutralCell(int cellBehaviourPosition)
        {
            CellBehaviorPosition = cellBehaviourPosition;
        }

        public int GetFinalPosition()
        {
            return CellBehaviorPosition;
        }
    }
}
