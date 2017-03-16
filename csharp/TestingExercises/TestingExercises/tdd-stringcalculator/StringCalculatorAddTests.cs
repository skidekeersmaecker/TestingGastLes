using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingExercises
{
    [TestClass]
    public class StringCalculatorAddTests
    {
        private readonly StringCalculator _calculator;

        public StringCalculatorAddTests()
        {
            _calculator = new StringCalculator();
        }

        [TestMethod]
        public void YourTestsGoHere()
        {
            Assert.Fail("Write tests step-by-step BEFORE implementing the features");
        }
    }
}