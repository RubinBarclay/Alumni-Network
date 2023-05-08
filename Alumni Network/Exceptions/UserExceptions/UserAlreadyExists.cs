using Alumni_Network.Models.Domain;

namespace Alumni_Network.Exceptions.UserExceptions
{
    public class UserAlreadyExists : Exception
    {
        public User User { get; set; }

        public UserAlreadyExists(string sub) : base($"A user with this sub already exists. Sub: {sub}") { }

        // Pass the existing user to the exception so that the create new user method can return the existing user
        public UserAlreadyExists(string sub, User user) : base($"A user with this sub already exists. Sub: {sub}")
        {
            User = user;
        }
    }
}
