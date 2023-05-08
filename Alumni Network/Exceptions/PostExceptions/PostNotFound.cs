namespace Alumni_Network.Exceptions.PostExceptions
{
    public class PostNotFound : Exception
    {
        public PostNotFound(int id) : base($"Post with ID {id} does not exist.")
        {

        }
    }
}
