namespace Alumni_Network.Exceptions.UserExceptions
{
    public class UserNotFound : Exception
    {
        public UserNotFound(int id) : base($"User with ID {id} does not exist.")
        {

        }

        public UserNotFound(string sub) : base($"User with this sub does not exist. Sub: {sub}")
        {

        }
    }
}
