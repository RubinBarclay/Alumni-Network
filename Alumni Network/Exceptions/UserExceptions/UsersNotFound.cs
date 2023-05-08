namespace Alumni_Network.Exceptions.UserExceptions
{
    public class UsersNotFound : Exception
    {
        public UsersNotFound() : base("Could not find any users")
        {

        }
    }
}
