using System;

namespace TestingExercises.beeroclock
{

    public interface IClock
    {
        DateTime Now();
    }

    public class SystemClock : IClock
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
    public class BeerOClockChecker
    {
        private readonly IClock _clock;

        public BeerOClockChecker(IClock clock)
        {
            _clock = clock;
        }

        public BeerOClockChecker(): this(new SystemClock())
        {

        }

        private const int BeerOClock = 16;

        public bool IsBeerOClock()
        {
            return Now().Hour >= BeerOClock;
        }

        protected virtual DateTime Now()
        {
            return _clock.Now();
        }
    }


}