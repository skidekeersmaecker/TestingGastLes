namespace TestingExercises.tripservice
{
    public class UserSession
    {
        private static readonly UserSession Instance = new UserSession();

        private UserSession()
        {
        }

        public static UserSession GetInstance()
        {
            return Instance;
        }

        public User GetLoggedInUser()
        {
            throw new CollaboratorCallException(
                    "UserSession.GetLoggedInUser() should not be called in an unit test");
        }
    }
}