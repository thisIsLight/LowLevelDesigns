namespace Tests.Dice
{
    public class DiceTest
    {
        [Test]
        public void Test1()
        {
            var dice = new SnakesLadderGame.SnakesAndLadder.Dice.Dice();

            var result = dice.GetScore();

            Assert.IsTrue(result < 7 && result > 0);
        }
    }
}
