using OefeningD;
using TestHelper;

namespace TestOefeningD
{
    [TestClass]
    public sealed class Test_D
    {
        [TestMethod]
        public void Constructor_Game()
        {
            HelperMethods.AssertConstructor(
                "Game",
                "Minecraft",
                29.99,
                150);
        }
        [TestMethod]
        public void VoegSpelerToe_1()
        {
            var game = new Game("Minecraft", 20, 10);

            game.VoegSpelerToe();

            Assert.AreEqual(11, game.AantalSpelers);
        }
        [TestMethod]
        public void VoegSpelerToe_5()
        {
            var game = new Game("Minecraft", 20, 10);

            for (int i = 0; i < 5; i++)
            {
                game.VoegSpelerToe();
            }

            Assert.AreEqual(15, game.AantalSpelers);
        }
        [TestMethod]
        public void VerwijderSpeler_1()
        {
            var game = new Game("Minecraft", 20, 10);

            game.VerwijderSpeler();

            Assert.AreEqual(9, game.AantalSpelers);
        }
        [TestMethod]
        public void VerwijderSpeler_GeenNegatieveWaarde()
        {
            var game = new Game("Minecraft", 20, 0);

            game.VerwijderSpeler();

            Assert.AreEqual(0, game.AantalSpelers);
        }
        [TestMethod]
        public void BerekenOmzet_Test1()
        {
            var game = new Game("Minecraft", 20, 10);

            Assert.AreEqual(200, game.BerekenOmzet());
        }
        [TestMethod]
        public void BerekenOmzet_Test2()
        {
            var game = new Game("Minecraft", 15, 25);

            Assert.AreEqual(375, game.BerekenOmzet());
        }
        [TestMethod]
        public void BerekenOmzet_GeenSpelers()
        {
            var game = new Game("Minecraft", 20, 0);

            Assert.AreEqual(0, game.BerekenOmzet());
        }
        [TestMethod]
        public void IsPopulair_False()
        {
            var game = new Game("Minecraft", 20, 99);

            Assert.IsFalse(game.IsPopulair());
        }
        [TestMethod]
        public void IsPopulair_Grenswaarde()
        {
            var game = new Game("Minecraft", 20, 100);

            Assert.IsTrue(game.IsPopulair());
        }
        [TestMethod]
        public void IsPopulair_True()
        {
            var game = new Game("Minecraft", 20, 500);

            Assert.IsTrue(game.IsPopulair());
        }
        [TestMethod]
        public void GeefInfo_Test1()
        {
            var game = new Game("Minecraft", 20, 150);

            Assert.AreEqual(
                "Minecraft heeft 150 spelers.",
                game.GeefInfo());
        }
        [TestMethod]
        public void GeefInfo_Test2()
        {
            var game = new Game("Fortnite", 0, 500);

            Assert.AreEqual(
                "Fortnite heeft 500 spelers.",
                game.GeefInfo());
        }
    }
}
