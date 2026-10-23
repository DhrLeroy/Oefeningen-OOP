
using OefeningA;
using TestHelper;

namespace TestOefeningA
{
    [TestClass]
    public sealed class Test_A
    {
        [TestMethod]
        public void Constructor_Bankrekening()
        {
            HelperMethods.AssertConstructor(
                "Bankrekening",
                "BE123",
                "Jan Janssens",
                500.0
            );
        }
        [TestMethod]
        public void KanAfhalen_VoldoendeSaldo()
        {
            var rekening = new Bankrekening("BE1", "Jan", 500);

            Assert.IsTrue(rekening.KanAfhalen(200));
        }
        [TestMethod]
        public void KanAfhalen_OnvoldoendeSaldo()
        {
            var rekening = new Bankrekening("BE1", "Jan", 500);

            Assert.IsFalse(rekening.KanAfhalen(700));
        }
        [TestMethod]
        public void Stort_Test()
        {
            var rekening = new Bankrekening("BE1", "Jan", 500);

            rekening.Stort(300);

            Assert.AreEqual(800, rekening.Saldo);
        }
        [TestMethod]
        public void Afhalen_Geldig()
        {
            var rekening = new Bankrekening("BE1", "Jan", 500);

            rekening.Afhalen(200);

            Assert.AreEqual(300, rekening.Saldo);
        }
        [TestMethod]
        public void Afhalen_Ongeldig()
        {
            var rekening = new Bankrekening("BE1", "Jan", 500);

            rekening.Afhalen(800);

            Assert.AreEqual(500, rekening.Saldo);
        }
        [TestMethod]
        public void GeefOverzicht_Test()
        {
            var rekening = new Bankrekening("BE123", "Jan Janssens", 450);

            Assert.AreEqual(
                "Jan Janssens (BE123) heeft 450 euro op zijn rekening.",
                rekening.GeefOverzicht()
            );
        }
    }
}
