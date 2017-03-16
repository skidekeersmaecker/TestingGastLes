namespace TestingExercises.calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            if (a == 0) return 0;

            return b + Multiply(a - 1, b);
        }
    }
}