namespace Alumni_Network.Exceptions.PostExceptions
{
    public class PostsNotFound : Exception
    {
        public PostsNotFound() : base("Could not find any posts")
        {

        }
    }
}
