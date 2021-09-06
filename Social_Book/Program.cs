using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Social_Book
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            List<User> users = new List<User>();

            //Make some users
            User u1 = new User("Makis", "iis1998@uom.edu.gr");
            User u2 = new User("Petros", "ics1924@uom.edu.gr");
            User u3 = new User("Maria", "iis2012@uom.edu.gr");
            User u4 = new User("Gianna", "iis19133@uom.edu.gr");
            User u5 = new User("Nikos", "dai1758@uom.edu.gr");
            User u6 = new User("Babis", "ics19104@uom.edu.gr");
            User u7 = new User("Stella", "dai1827@uom.edu.gr");
            User u8 = new User("Eleni", "ics2086@gmail.com");

            //Make some groups
            Group g1 = new Group("WebGurus", "A group for web passionates");
            ClosedGroup g2 = new ClosedGroup("ExamSolutions", "Solutions to common exam questions");

            //Make some friendships
            u1.addFriend(u2);
            u1.addFriend(u5);
            u5.addFriend(u6);
            u3.addFriend(u4);
            u3.addFriend(u2);
            u4.addFriend(u6);
            u5.addFriend(u3);
            u1.addFriend(u6);
            u5.addFriend(u2);
            u7.addFriend(u1);

            //Common friends of Nikos and Gianna
            u5.commonFriends(u4);

            //Common friends of Makis and Nikos
            u1.commonFriends(u5);

            //Friends of Makis
            u1.getFriends();

            //Friends of Maria
            u3.getFriends();

            //Enroll Gianna in WebGurus
            g1.addUser(u4);

            //Enroll Maria in WebGurus
            g1.addUser(u3);

            //Enroll Petros in WebGurus
            g1.addUser(u2);

            //Enroll Gianna in ExamSolutions
            g2.addUser(u4);

            //Enroll Nikos in ExamSolutions
            g2.addUser(u5);

            //Enroll Babis in ExamSolutions
            g2.addUser(u6);

            //Enroll Nikos in ExamSolutions
            g2.addUser(u5);

            //Groups that Gianna has been enrolled in
            u4.printGroups();

            //Members of group WebGurus
            g1.printMembers();

            //Members of group ExamSolutions
            g2.printMembers();

            //Gianna has been infected. The following users have to be tested
            u4.posiblyInfected();

            DateTime time = new DateTime(2021, 8, 30, 18, 11, 12);
            u1.addPost(new Post(time, "eimai o makis", u1));

            DateTime time2 = new DateTime(2021, 8, 30, 18, 11, 13);
            u1.addPost(new Post(time2, "geia sou maki", u1));

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            users.Add(u5);
            users.Add(u6);
            users.Add(u7);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartPage startPage = new StartPage(users);
            startPage.Text = "Είσοδος Χρήστη";
            Application.Run(startPage);

        }

        
        
    }

}
   
