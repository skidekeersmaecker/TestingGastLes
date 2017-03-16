using System;

namespace TestingExercises
{
    public class BeerOClockChecker
    {
        private const int BeerOClock = 16;

        public bool IsBeerOClock()
        {
            return Now().Hour >= BeerOClock;
        }

        protected virtual DateTime Now()
        {
            return DateTime.Now;
        }
    }
}