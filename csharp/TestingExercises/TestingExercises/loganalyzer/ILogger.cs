namespace TestingExercises.loganalyzer
{
    public interface ILogger
    {
        void LogError(string line);

        void LogInfo(string line);
    }
}