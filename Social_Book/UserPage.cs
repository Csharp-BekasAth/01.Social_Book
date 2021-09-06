using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Social_Book
{
    public partial class UserPage : Form
    {
        private User user;
        private List<User> users;
        private List<Post> posts;
        private List<User> suggested;
        private List<User> friends;
 
        public UserPage(User user, List<User> users)
        {
            InitializeComponent();
            this.user = user;
            this.users = users;
            userEmailTxt.Text = user.Email;
            userNameTxt.Text = user.Name;
            this.posts = user.getAllPosts();
            this.suggested = user.suggestFriend();
            this.friends = user.getFriends();

            foreach(Post post in posts)
            {
                allPostsTxt.Text += post.User.Name + ": " + post.Timestamp.ToString() 
                    + " " + post.Body + Environment.NewLine;
            }

            foreach(User aUser in suggested)
            {
                suggestedListBox.Items.Add(aUser.Name);
            }

            foreach (User aUser in friends)
            {
                allFriendsList.Items.Add(aUser.Name);
            }
        }

        private void userNameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userEmailTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void startPageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPage startPage = new StartPage(users);
            startPage.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void suggestedListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newPostBtn_Click(object sender, EventArgs e)
        {
            string body = newPostTxt.Text;
            DateTime time = DateTime.Now;
            Post post = new Post(time, body, user);

            user.addPost(post);

            this.posts = user.getAllPosts();

            allPostsTxt.Text = "";

            foreach (Post aPost in posts)
            {
                allPostsTxt.Text += aPost.User.Name + ": " + aPost.Timestamp.ToString()
                    + " " + aPost.Body + Environment.NewLine;
            }
        }

        private void addFriend_Click(object sender, EventArgs e)
        {
            string friendsName = addFriendTxt.Text;
            User friend;

            foreach(User aUser in users)
            {
                if (aUser.Name.Equals(friendsName))
                {
                    friend = aUser;
                    user.addFriend(friend);
                    break;
                }
            }

        }

        private void allFriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
