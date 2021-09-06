using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Book
{
    public class ClosedGroup : Group
    {
        //Constructor
        public ClosedGroup(string name, string description) : base(name, description)
        {
            
        }

        //Method that adds a user in the Closed Group
        public override void addUser(User aUser)
        {
            Boolean added = false;

            if (members.Count == 0)
            {
                members.Add(aUser);
                aUser.addGroup(this);
                added = true;
            }
            else
            {

                foreach (User user in members)
                {
                    List<User> friends = user.getFriends();

                    if (friends.Contains(aUser) && !members.Contains(aUser))
                    {
                        members.Add(aUser);
                        aUser.addGroup(this);
                        added = true;
                        break;
                    }
                }
            }

            if(added)
            {
                Console.WriteLine(aUser.Name + " has been successfully enrolled in group " + name);
            }
            else
            {
                Console.WriteLine("FAILED: " + aUser.Name + " cannot be enrolled in group " + name);
            }

        }

    }
}
