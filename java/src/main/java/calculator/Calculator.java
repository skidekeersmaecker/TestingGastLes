package calculator;

public class Calculator {
    public int add(int a, int b) {
        return a + b;
    }

    public int multiply(int a, int b) {
        if (a == 0) return 0;

        return b + multiply(a - 1, b);
    }
}
