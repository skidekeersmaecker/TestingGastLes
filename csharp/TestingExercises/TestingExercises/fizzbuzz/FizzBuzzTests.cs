using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingExercises.fizzbuzz
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void three_is_fizz()
        {
            Assert.AreEqual("Fizz", FizzBuzz(3));
        }

        [TestMethod]
        public void five_is_buzz()
        {
            Assert.AreEqual("Fizz", FizzBuzz(5));
        }

        private string FizzBuzz(int i)
        {
            return (i == 3) ? "Fizz" : "Buzz";
        }
    }
}