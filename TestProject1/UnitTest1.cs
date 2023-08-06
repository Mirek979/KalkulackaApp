using KalkulackaApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScitani()
        {
            Kalkulacka kalk = new Kalkulacka();
            Assert.AreEqual(5, kalk.Secti(2, 3));
            Assert.AreEqual(10, kalk.Secti(5, 5));


        }
        [TestMethod]
        public void TestNasobeni()
        {
            Kalkulacka kalk = new Kalkulacka();
            Assert.AreEqual(25, kalk.Vynasob(5, 5));
            Assert.AreEqual(30, kalk.Vynasob(5, 6));
        }
        [TestMethod] 
        public void TestOdecitani()
        {
            Kalkulacka kalk = new Kalkulacka();
            Assert.AreEqual(0, kalk.Odecti(5, 5));
            Assert.AreEqual(30, kalk.Odecti(50, 20));
        }
        [TestMethod]
        public void TestDeleni()
        {
            Kalkulacka kalk = new Kalkulacka();
            Assert.AreEqual(5, kalk.Vydel(25, 5));
            Assert.AreEqual(5, kalk.Vydel(30, 6));
        }

    }
}