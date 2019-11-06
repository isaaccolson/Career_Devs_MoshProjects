using System;

namespace PostProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var post = new Post("Cool Title");

            post.Vote(true);
            post.Vote(false);

            Console.WriteLine(post.title);

        }

        public class Post
        {
            public string title { get; private set; }
            private DateTime creationDate;
            private int upVotes, downVotes;

            public Post(string _title)
            {
                creationDate = DateTime.Now;
                title = _title;
            }

            public void Vote(bool _vote)
            {
                if (_vote)
                {
                    upVotes++;
                }
                else
                {
                    downVotes++;
                }

                Console.WriteLine("Upvotes: {0} Downvotes: {1}", upVotes, downVotes);
            }

        }

    }
}
