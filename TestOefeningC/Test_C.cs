using OefeningC;
using TestHelper;

namespace TestOefeningC
{
    [TestClass]
    public sealed class Test_C
    {
        [TestMethod]
        public void Constructor_Dier()
        {
            HelperMethods.AssertConstructor(
                "Dier",
                "Simba",
                "Leeuw",
                5,
                true);
        }
        [TestMethod]
        public void Verjaar_EenKeer()
        {
            var dier = new Dier("Simba", "Leeuw", 5, true);

            dier.Verjaar();

            Assert.AreEqual(6, dier.Leeftijd);
        }
        [TestMethod]
        public void Verjaar_DrieKeer()
        {
            var dier = new Dier("Simba", "Leeuw", 5, true);

            dier.Verjaar();
            dier.Verjaar();
            dier.Verjaar();

            Assert.AreEqual(8, dier.Leeftijd);
        }
        [TestMethod]
        public void WordtZiek_Test()
        {
            var dier = new Dier("Simba", "Leeuw", 5, true);

            dier.WordtZiek();

            Assert.IsFalse(dier.IsGezond);
        }
        [TestMethod]
        public void Genees_Test()
        {
            var dier = new Dier("Simba", "Leeuw", 5, false);

            dier.Genees();

            Assert.IsTrue(dier.IsGezond);
        }
        [TestMethod]
        public void HeeftSeniorLeeftijd_False()
        {
            var dier = new Dier("Simba", "Leeuw", 9, true);

            Assert.IsFalse(dier.HeeftSeniorLeeftijd());
        }
        [TestMethod]
        public void HeeftSeniorLeeftijd_Grenswaarde()
        {
            var dier = new Dier("Simba", "Leeuw", 10, true);

            Assert.IsTrue(dier.HeeftSeniorLeeftijd());
        }
        [TestMethod]
        public void HeeftSeniorLeeftijd_True()
        {
            var dier = new Dier("Simba", "Leeuw", 14, true);

            Assert.IsTrue(dier.HeeftSeniorLeeftijd());
        }
        [TestMethod]
        public void GeefStatus_Gezond()
        {
            var dier = new Dier("Simba", "Leeuw", 5, true);

            Assert.AreEqual(
                "Simba (Leeuw) - 5 jaar - Gezond",
                dier.GeefStatus());
        }
        [TestMethod]
        public void GeefStatus_Ziek()
        {
            var dier = new Dier("Simba", "Leeuw", 5, false);

            Assert.AreEqual(
                "Simba (Leeuw) - 5 jaar - Ziek",
                dier.GeefStatus());
        }
    }
}
