using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Social_Book
{
    public partial class StartPage : Form
    {
        private List<User> users;
        public StartPage(List<User> users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void userPagebBtn_Click(object sender, EventArgs e)
        {
            User user = new User("","");
            Boolean found = false;

            foreach(User aUser in users)
            {
                if(aUser.Name.Equals(userNameTxt.Text))
                {
                    user = aUser;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                this.Hide();
                UserPage userPage = new UserPage(user, users);
                userPage.Text = "Σελίδα Χρήστη";
                
                userPage.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("There is no user " + userNameTxt.Text);
            }

            
        }

        private void infectionBtn_Click(object sender, EventArgs e)
        {
            User user = new User("", "");
            Boolean found = false;

            foreach (User aUser in users)
            {
                if (aUser.Name.Equals(userNameTxt.Text))
                {
                    user = aUser;
                    found = true;
                    break;
                }
            }

            if (found)
            {
                this.Hide();
                InfectionPage infectionPage = new InfectionPage(user);
                infectionPage.Text = "Πιθανή Μετάδοση Ιού";

                infectionPage.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("There is no user " + userNameTxt.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = userNameTxt.Text;
            string email = userEmailTxt.Text;

            User user = new User(name, email);
            Boolean validName = true;
            
            foreach(User aUser in users)
            {
                if (aUser.Name.Equals(name))
                {
                    validName = false;
                    break;
                }
            }

            if (validName)
            {
                if (user.validEmail())
                {
                    users.Add(user);
                    MessageBox.Show(user.Name + " has enrolled");
                }
                else
                {
                    MessageBox.Show("Invalid Email");
                }
            }
            else
            {
                MessageBox.Show("This name is used");
            }

        }

        private void showUsersBtn_Click(object sender, EventArgs e)
        {
            foreach(User aUser in users)
            {
                allUsersListBox.Items.Add(aUser.Name);
            }
            
        }
    }
}
