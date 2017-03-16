using System;

namespace TestingExercises.tripservice
{
    public class CollaboratorCallException : Exception
    {
        public CollaboratorCallException(string message) 
            : base(message)
        {
        }
    }
}