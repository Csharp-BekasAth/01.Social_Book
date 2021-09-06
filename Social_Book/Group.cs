using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Social_Book
{
    public class Group
    {

        protected string name;            //Group's name
        protected string description;         //A description of this group
        protected List<User> members = new List<User>();      //The list of group's members
        
        //Constructor
        public Group(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        //Method that returns group's name
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Method that returns group's description
        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }

        //Method that return if a user is member of the group
        public Boolean isMember(User aUser)
        {
            Boolean isMem = false;

            if(members.Contains(aUser))
            {
                isMem = true;
            }

            return isMem;
        }

        //Method that adds a user in the group
        public virtual void addUser(User aUser)
        {
            Boolean added = false;

            if (!members.Contains(aUser))
            {
                members.Add(aUser);
                aUser.addGroup(this);
                added = true;
            }

            if (added)
            {
                Console.WriteLine(aUser.Name + " has been successfully enrolled in group " + name);
            }
            else
            {
                Console.WriteLine("FAILED: " + aUser.Name + " cannot be enrolled in group " + name);
            }
        }

        //Method that print group's members
        public void printMembers()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Members of group " + name);
            Console.WriteLine("*******************************");

            int i = 1;

            foreach (User user in members)
            {
                Console.WriteLine(i + ": " + user.Name);
            }

            Console.WriteLine("-----------------------------");
        }
    }
}
