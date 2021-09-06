using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Book
{
    public class Post
    {
        private DateTime timestamp;         //Date and time of the post
        private string body;            //The text of the post
        private User user;          //User who posted the post

        //Constructor
        public Post(DateTime timestamp, string body, User user)
        {
            this.timestamp = timestamp;
            this.body = body;
            this.user = user;
        }

        //Setters and Getters
        public DateTime Timestamp
        {
            get { return this.timestamp; }
            set { this.timestamp = value; }
        }
        public string Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        public User User
        {
            get { return this.user; }
            set { this.user = value; }
        }

       

    }
}
