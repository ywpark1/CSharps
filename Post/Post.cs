using System;

namespace Post
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        private readonly DateTime _createdAt = DateTime.Now;
        private int _vote = 0;

        public void UpVote() {
            _vote++;
        }

        public void DownVote() {
            _vote--;
        }

        public void Display() {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(_createdAt);
            Console.WriteLine(_vote);
        }
    }
}