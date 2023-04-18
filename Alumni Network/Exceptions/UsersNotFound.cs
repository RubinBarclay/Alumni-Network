namespace Alumni_Network.Exceptions
{
    public class UsersNotFound : Exception
    {
        public UsersNotFound() : base("Could not find any users")
        {
            
        }
    }
}
