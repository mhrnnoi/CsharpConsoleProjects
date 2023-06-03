using System;

namespace stackoverflow2
{
    public class stackoverflow
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime DateTime { get; private set; }
        public int VoteValue { get; private set; }

        public stackoverflow()
        {
            this.VoteValue = 0;
            this.DateTime = DateTime.Now;
        }
        public stackoverflow(string title, string description)
            :this()
        {
            this.Title =  title;
            this.Description = description;
        }

        public void UpVote()
        {
            VoteValue++;
        }
        public void DownVote()
        {
            VoteValue--;
            
        }

    }
}
