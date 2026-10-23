using OefeningB;
using TestHelper;

namespace TestOefeningB
{
    [TestClass]
    public sealed class Test_B
    {
        [TestMethod]
        public void Constructor_Boek()
        {
            HelperMethods.AssertConstructor(
                "Boek",
                "Harry Potter",
                "J.K. Rowling",
                false
            );
        }
        [TestMethod]
        public void KanUitlenen_Wel()
        {
            var boek = new Boek("HP", "Rowling", false);

            Assert.IsTrue(boek.KanUitlenen());
        }
        [TestMethod]
        public void KanUitlenen_Niet()
        {
            var boek = new Boek("HP", "Rowling", true);

            Assert.IsFalse(boek.KanUitlenen());
        }
        [TestMethod]
        public void LeenUit_Test()
        {
            var boek = new Boek("HP", "Rowling", false);

            boek.LeenUit();

            Assert.IsTrue(boek.Uitgeleend);
        }
        [TestMethod]
        public void BrengTerug_Test()
        {
            var boek = new Boek("HP", "Rowling", true);

            boek.BrengTerug();

            Assert.IsFalse(boek.Uitgeleend);
        }
        [TestMethod]
        public void GeefStatus_Beschikbaar()
        {
            var boek = new Boek("Harry Potter", "Rowling", false);

            Assert.AreEqual(
                "Harry Potter - Beschikbaar",
                boek.GeefStatus()
            );
        }
        [TestMethod]
        public void GeefStatus_Uitgeleend()
        {
            var boek = new Boek("Harry Potter", "Rowling", true);

            Assert.AreEqual(
                "Harry Potter - Uitgeleend",
                boek.GeefStatus()
            );
        }
    }
}
