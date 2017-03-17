using System.Collections.Generic;

namespace TestingExercises.tripservice
{
    public class TripDAO
    {
        public static List<Trip> FindTripsByUser(User user)
        {
            throw new CollaboratorCallException(
                "TripDAO should not be invoked on an unit test.");
        }
    }
}