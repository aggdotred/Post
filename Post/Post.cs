using System;

namespace Post
{
        class Post {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime CreatedAt { get; }
        int UpVotes;
        int DownVotes;

        public Post(string _title, string _description)
        {
            Title = _title;
            Description = _description;
            UpVotes = 0;
            DownVotes = 0;
            CreatedAt = DateTime.Now;
        }

        public void voteUp()
        {
            UpVotes++;
        }

        public void voteDown()
        {
            DownVotes++;
        }

        public int getVotes()
        {
            return UpVotes - DownVotes;
        }
    }
}
