using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Social_Book
{
    public partial class InfectionPage : Form
    {
        private User user;
        public InfectionPage(User user)
        {
            InitializeComponent();
            this.user = user;

            List<User> infected = user.posiblyInfected();

            infectionTxt.Text = "*******************************\n" + Environment.NewLine + 
                              user.Name + " has been infected. The following users have to be tested\n" + Environment.NewLine +
                              "*******************************" + Environment.NewLine;
            foreach (User aUser in infected)
            {
                infectionTxt.Text += aUser.Name + Environment.NewLine;
            }

            infectionTxt.Text += "-----------------------------";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
