
namespace Social_Book
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userPagebBtn = new System.Windows.Forms.Button();
            this.infectionBtn = new System.Windows.Forms.Button();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.newUserBtn = new System.Windows.Forms.Button();
            this.userEmailTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.showUsersBtn = new System.Windows.Forms.Button();
            this.allUsersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // userPagebBtn
            // 
            this.userPagebBtn.Location = new System.Drawing.Point(100, 142);
            this.userPagebBtn.Name = "userPagebBtn";
            this.userPagebBtn.Size = new System.Drawing.Size(256, 29);
            this.userPagebBtn.TabIndex = 0;
            this.userPagebBtn.Text = "Enter User Page";
            this.userPagebBtn.UseVisualStyleBackColor = true;
            this.userPagebBtn.Click += new System.EventHandler(this.userPagebBtn_Click);
            // 
            // infectionBtn
            // 
            this.infectionBtn.Location = new System.Drawing.Point(398, 142);
            this.infectionBtn.Name = "infectionBtn";
            this.infectionBtn.Size = new System.Drawing.Size(241, 29);
            this.infectionBtn.TabIndex = 1;
            this.infectionBtn.Text = "Show Potential Infections";
            this.infectionBtn.UseVisualStyleBackColor = true;
            this.infectionBtn.Click += new System.EventHandler(this.infectionBtn_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(323, 49);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(114, 27);
            this.userNameTxt.TabIndex = 2;
            this.userNameTxt.Text = "User Name";
            this.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(100, 49);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(136, 29);
            this.newUserBtn.TabIndex = 3;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // userEmailTxt
            // 
            this.userEmailTxt.Location = new System.Drawing.Point(514, 49);
            this.userEmailTxt.Name = "userEmailTxt";
            this.userEmailTxt.Size = new System.Drawing.Size(125, 27);
            this.userEmailTxt.TabIndex = 4;
            this.userEmailTxt.Text = "User Email";
            this.userEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(291, 272);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(156, 29);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save Social Book";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // showUsersBtn
            // 
            this.showUsersBtn.Location = new System.Drawing.Point(544, 297);
            this.showUsersBtn.Name = "showUsersBtn";
            this.showUsersBtn.Size = new System.Drawing.Size(94, 29);
            this.showUsersBtn.TabIndex = 6;
            this.showUsersBtn.Text = "show users";
            this.showUsersBtn.UseVisualStyleBackColor = true;
            this.showUsersBtn.Click += new System.EventHandler(this.showUsersBtn_Click);
            // 
            // allUsersListBox
            // 
            this.allUsersListBox.FormattingEnabled = true;
            this.allUsersListBox.ItemHeight = 20;
            this.allUsersListBox.Location = new System.Drawing.Point(644, 297);
            this.allUsersListBox.Name = "allUsersListBox";
            this.allUsersListBox.Size = new System.Drawing.Size(150, 104);
            this.allUsersListBox.TabIndex = 7;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allUsersListBox);
            this.Controls.Add(this.showUsersBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.userEmailTxt);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.infectionBtn);
            this.Controls.Add(this.userPagebBtn);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userPagebBtn;
        private System.Windows.Forms.Button infectionBtn;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.TextBox userEmailTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button showUsersBtn;
        private System.Windows.Forms.ListBox allUsersListBox;
    }
}