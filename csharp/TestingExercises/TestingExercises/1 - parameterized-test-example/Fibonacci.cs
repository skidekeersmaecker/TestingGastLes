namespace TestingExercises
{
    public class Fibonacci
    {
        public static int Compute(int input)
        {
            if (input == 0) return 0;
            if (input == 1) return 1;

            return Compute(input - 1) + Compute(input - 2);
        }
    }
}