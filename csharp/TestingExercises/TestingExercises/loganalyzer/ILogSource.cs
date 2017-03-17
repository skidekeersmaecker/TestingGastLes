using System.Collections.Generic;

namespace TestingExercises.loganalyzer
{
    public interface ILogSource
    {
        List<string> GetLines();
    }
}