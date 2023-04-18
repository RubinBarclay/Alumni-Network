namespace Alumni_Network.Exceptions
{
    public class UserAlreadyExists : Exception
    {
        public UserAlreadyExists(string sub) : base($"A user with this sub already exists. Sub: {sub}")
        {
            
        }
    }
}
