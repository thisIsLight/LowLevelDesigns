using SnakesLadderGame.SnakesAndLadder.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.BoardTest
{
    public class BoardTest
    {
        [Test]
        public void GetNewPosition_NeutralCellAccess_ReturnAdditionValue()
        {
            var board = new Board();
            var result = board.GetNewPosition(10, 6);

            Assert.IsTrue(result == 16);
        }

        [Test]
        public void GetNewPosition_SnakeCellAccess_ReturnValueWithFiveMinus()
        {
            var board = new Board();
            var result = board.GetNewPosition(10, 5);

            Assert.IsTrue(result == 5);
        }

        [Test]
        public void GetNewPosition_LadderCellAccess_ReturnAdditionValueByFive()
        {
            var board = new Board();
            var result = board.GetNewPosition(19, 1);

            Assert.IsTrue(result == 25);
        }

        [Test]
        public void GetNewPosition_NeutralCellAccessWithScoreMoreThan100_ReturnSamePosition()
        {
            var board = new Board();
            var result = board.GetNewPosition(98, 3);

            Assert.IsTrue(result == 98);
        }
    }
}
