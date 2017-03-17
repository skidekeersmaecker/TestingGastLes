using System.Collections.Generic;

namespace TestingExercises.tripservice
{
    public class TripService
    {
        public List<Trip> GetTripsByUser(User user)
        {
            var tripList = new List<Trip>();
            var loggedUser = UserSession.GetInstance().GetLoggedInUser();
            var isFriend = false;
            if (loggedUser != null) {
                foreach(var friend in user.GetFriends()) {
                    if (friend.Equals(loggedUser)) {
                        isFriend = true;
                        break;
                    }
                }
                if (isFriend) {
                    tripList = TripDAO.FindTripsByUser(user);
                }
                return tripList;
            } else {
                throw new UserNotLoggedInException();
            }
    }        
    }
}