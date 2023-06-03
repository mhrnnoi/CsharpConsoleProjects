using System;

namespace stackoverflow2
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new stackoverflow("post number 1", "its about you ");

            post.DownVote();

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();


            post.DownVote();
            post.DownVote();

            Console.WriteLine(post.Description);            
            Console.WriteLine(post.DateTime);            
            Console.WriteLine(post.Title);            
            Console.WriteLine(post.VoteValue);            





        }
    }
}
