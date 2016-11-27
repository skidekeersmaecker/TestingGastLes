public class Fibonacci {
    public static int compute(int input) {
        if (input == 0) return 0;
        if (input == 1) return 1;

        return compute(input - 1) + compute(input - 2);
    }
}
