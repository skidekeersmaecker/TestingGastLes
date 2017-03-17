using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingExercises.calculator
{

    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CanAddPos()
        {
            Calculator calculater = new Calculator();

            Assert.AreEqual(calculater.Add(2, 3), 5);
        }
        [TestMethod]
        public void CanAddNegAndPos()
        {
            Calculator calculater = new Calculator();

            Assert.AreEqual(calculater.Add(-2, 3), 1);
        }
        [TestMethod]
        public void CanAddNeg()
        {
            Calculator calculater = new Calculator();

            Assert.AreEqual(calculater.Add(-2, -3), -5);
        }

       /* [TestMethod]
        public void CanMultiply()
        {
            Calculator calculater = new Calculator();
            
            Assert.AreEqual(calculater.Multiply(-3, 3), -9);
        }*/
    }
}