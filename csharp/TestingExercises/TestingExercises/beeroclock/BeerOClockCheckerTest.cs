using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace TestingExercises.beeroclock
{
    [TestClass]
    public class BeerOClockCheckerTest
    {
        [TestMethod]
        public void KnowWhenItIsNotBeerOClock()
        {
            var alwaysOneClock = Substitute.For<IClock>();
            alwaysOneClock.Now().Returns(DateTime.Parse("13:00:00"));

            var checker = new BeerOClockChecker(alwaysOneClock);

            Assert.IsFalse(checker.IsBeerOClock());
        } 
    }
}