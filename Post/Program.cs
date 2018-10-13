using System;

namespace Post
{
    class Program
    {
        public static void RandomVote(ref Post p) {
            var random = new Random();
            var randNum = random.Next(0, 100);
            for(var i = 1; i <= randNum; i++)
                p.UpVote();

            randNum = random.Next(0, 100);
            for(var i = 1; i <= randNum; i++)
                p.DownVote();
        }

        static void Main(string[] args)
        {
            var post = new Post();

            post.Title = "This is title";
            post.Description = "Description";

            RandomVote(ref post);

            post.Display();
        }
    }
}
