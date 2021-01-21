using System;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post("test", "this is only a test");
            post.voteUp();
            post.voteUp();
            post.voteUp();
            post.voteDown();

            Console.WriteLine(post.Title);
            Console.WriteLine(post.CreatedAt);
            Console.WriteLine(post.getVotes());
        }
    }
}
