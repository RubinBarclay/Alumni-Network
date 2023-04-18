namespace Alumni_Network.Exceptions
{
    public class UserNotFound : Exception
    {
        public UserNotFound(int id) : base($"User with ID {id} does not exist.")
        {
            
        }
    }
}
