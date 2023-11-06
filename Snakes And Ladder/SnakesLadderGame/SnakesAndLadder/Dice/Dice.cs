using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesLadderGame.SnakesAndLadder.Dice
{
    public class Dice
    {
        public Random RandomGenerator;

        public Dice()
        {
            RandomGenerator = new Random();
        }
        public int GetScore()
        {
            return RandomGenerator.Next(1,7);
        }
    }
}
