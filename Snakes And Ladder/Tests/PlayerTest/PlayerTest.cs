namespace Tests.PlayerTest
{
    public class PlayerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var player = new Player(1);
            var result = player.GetPosition();
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
