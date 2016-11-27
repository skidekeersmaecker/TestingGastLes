package beeroclock;

import java.util.Calendar;

public class BeerOClockChecker {

    private final int BEER_O_CLOCK = 16;

    public boolean isBeerOClock() {
        return now().get(Calendar.HOUR_OF_DAY) >= BEER_O_CLOCK;
    }

    protected Calendar now() {
        return Calendar.getInstance();
    }
}
