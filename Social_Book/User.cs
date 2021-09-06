using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Windows.Forms;

namespace Social_Book
{
    public class User
    {
        private string name;            //User's name
        private string email;           //User's email

        private List<User> friends = new List<User>();          //The list of user's friends
        private List<Group> groups = new List<Group>();         //The list of groups that user is member
        private List<Post> posts = new List<Post>();            //The list of user's posts
        private Boolean valid_email = false;            //This variable is true when the user has valid email

        private static Regex pattern = new Regex("^(dai|ics|iis)[0-9]{3,5}(@uom\\.edu\\.gr)$");         //The pattern of valid email

        //Constructor
        public User(string name, string email)
        {
            
            Match m = pattern.Match(email);         //Email validation
                                                   
            if (m.Success)
            {
                this.name = name;
                this.email = email;
                valid_email = true;
            }
            else
            {
                Console.WriteLine("User " + name + " has not been created. Email format is not acceptable.");
                
            }
        }

        //Method that returns if a user has valid email
        public Boolean validEmail()
        {
            return valid_email;
        }

        //Getter and Setter of name variable
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        //Getter and Setter of email variable
        public string Email
        {
            get { return email; }
            set { this.email = value; }
        }

        //Method that add a User in friends list
        public void addFriend(User aUser)
        {
            if (!friends.Contains(aUser) && !aUser.Equals(this))
            {
                friends.Add(aUser);
                
                MessageBox.Show(name + " and " + aUser.Name + " are now friends!");
                aUser.friends.Add(this);
            }
            else if (friends.Contains(aUser))
            {
                MessageBox.Show(name + " and " + aUser.Name + " are already friends!");
            }
            else
            {
                MessageBox.Show("It is the same person!");
            }
        }

        //Method that returns true/false if two users are friends
        public Boolean areFriends(User aUser)
        {
            Boolean arefriends = false;

            foreach(User user in friends)
            {
                if (user.Equals(aUser))
                {
                    arefriends = true;
                    break;
                }
            }

            return arefriends;
        }

        //Method that return a list of user's friends
        public List<User> getFriends()
        {
            return friends;
        }

        //Method that adds a group in the list of groups
        public void addGroup(Group aGroup)
        {
            groups.Add(aGroup);
        }

        //Method that returns and print the common friends of the two users
        public List<User> commonFriends(User aUser)
        {
            List<User> common = new List<User>();
            int i = 1;

            foreach (User user in friends)
            {
                if (aUser.areFriends(user))
                {
                    common.Add(user);
                }
            }

            Console.WriteLine("**************************************\n" +
                              "Common friends of " + this.Name + " and " + aUser.Name +
                              "\n**************************************");

            foreach (User user in common)
            {
                Console.WriteLine(i++ + ": " + user.Name);
            }

            Console.WriteLine("--------------------------------------");

            return common;
        }

        //Method that prints user's friends
        public void printFriends()
        {
            int i = 1;
            Console.WriteLine("************************\n" +
                              "Friends of " + name +
                              "\n************************");
            foreach (User user in friends)
            {
                Console.WriteLine(i++ + ": " + user.Name);
            }

            Console.WriteLine("-----------------------");
        }

        //Method that prints the groups that user is member
        public void printGroups()
        {
            int i = 1;
            Console.WriteLine("**************************************\n" +
                              "Groups that " + name + " has been enrolled in " +
                              "\n**************************************");

            foreach(Group group in groups)
            {
                Console.WriteLine(i++ + ": " + group.Name);
            }

            Console.WriteLine("--------------------------------------");
        }

        /*Method that prints poeple that have posibly been infected 
        if the user has been infected (friends and friends of friends)*/
        public List<User> posiblyInfected()
        {
            List<User> posInf = new List<User>();

            foreach(User friend in friends)
            {
                List<User> friendsOfFriend = friend.getFriends();

                if (!(posInf.Contains(friend)))
                {
                    posInf.Add(friend);
                }

                foreach(User firendOfFriend in friendsOfFriend)
                {
                    if (!posInf.Contains(firendOfFriend) && !(firendOfFriend.Equals(this)))
                    {
                        posInf.Add(firendOfFriend);
                    }
                }

                
            }

            Console.WriteLine("*******************************\n" +
                              name + " has been infected. The following users have to be tested\n" +
                              "*******************************");
            foreach(User user in posInf)
            {
                Console.WriteLine(user.Name);
            }

            Console.WriteLine("-----------------------------");

            return posInf;
        }
        
        //Method that adds a post in the list of posts
        public void addPost(Post aPost)
        {
            posts.Add(aPost);
        }

        //Method that returns a list with all posts (them and their friends') with chronological order
        public List<Post> getAllPosts()
        {
            List<Post> allposts = posts;

            foreach(User friend in friends)
            {
                foreach (Post post in friend.posts)
                    allposts.Add(post);
            }

            allposts.Sort(new Comparison<Post>((x, y) => DateTime.Compare(x.Timestamp, y.Timestamp)));
            allposts.Reverse();
            
            return allposts;
        }

        /*Method that suggests a friend request.
        If A is friend with B and C, B is friend with A, C and E
        then this method will suggest to A, E as a friend*/
        public List<User> suggestFriend()
        {
            List<User> suggestedFriends = new List<User>();
           
            foreach(User friend in friends)
            {
                List<User> friendsOfFriend = friend.getFriends();
                List<User> commonFriends = this.commonFriends(friend);

                if(!(commonFriends.Count == 0))
                {
                    foreach (User friendOfFriend in friendsOfFriend)
                    {
                        if(!(friends.Contains(friendOfFriend)) && !(suggestedFriends.Contains(friendOfFriend)))
                        {
                            if(!friendOfFriend.Equals(this))
                                suggestedFriends.Add(friendOfFriend);
                        }
                    }
                }

            }

            return suggestedFriends;
        }
       


    }
}
