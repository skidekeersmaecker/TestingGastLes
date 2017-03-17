namespace TestingExercises.loganalyzer
{
    public class LogAnalyzer
    {
        private readonly ILogSource _logSource;
        private readonly ILogger _logger;

        public LogAnalyzer(ILogSource logSource, ILogger logger)
        {
            _logSource = logSource;
            _logger = logger;
        }

        public void Analyze()
        {
            foreach(var line in _logSource.GetLines())
            {
                if (line.Contains("Error: "))
                {
                    _logger.LogError(line);
                }
                else if (line.Contains("Info: "))
                {
                    _logger.LogInfo(line);
                }
            }

        }
    }
}