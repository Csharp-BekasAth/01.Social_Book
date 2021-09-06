
namespace Social_Book
{
    partial class UserPage
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
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userEmailTxt = new System.Windows.Forms.TextBox();
            this.startPageBtn = new System.Windows.Forms.Button();
            this.newPostBtn = new System.Windows.Forms.Button();
            this.recentPostsLbl = new System.Windows.Forms.Label();
            this.suggestedLbl = new System.Windows.Forms.Label();
            this.newPostTxt = new System.Windows.Forms.TextBox();
            this.suggestedListBox = new System.Windows.Forms.ListBox();
            this.allPostsTxt = new System.Windows.Forms.TextBox();
            this.addFriend = new System.Windows.Forms.Button();
            this.addFriendTxt = new System.Windows.Forms.TextBox();
            this.allFriendsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(42, 37);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(125, 27);
            this.userNameTxt.TabIndex = 0;
            this.userNameTxt.TextChanged += new System.EventHandler(this.userNameTxt_TextChanged);
            // 
            // userEmailTxt
            // 
            this.userEmailTxt.Location = new System.Drawing.Point(231, 37);
            this.userEmailTxt.Name = "userEmailTxt";
            this.userEmailTxt.Size = new System.Drawing.Size(269, 27);
            this.userEmailTxt.TabIndex = 1;
            this.userEmailTxt.TextChanged += new System.EventHandler(this.userEmailTxt_TextChanged);
            // 
            // startPageBtn
            // 
            this.startPageBtn.Location = new System.Drawing.Point(562, 37);
            this.startPageBtn.Name = "startPageBtn";
            this.startPageBtn.Size = new System.Drawing.Size(182, 29);
            this.startPageBtn.TabIndex = 2;
            this.startPageBtn.Text = "Back to Login Page";
            this.startPageBtn.UseVisualStyleBackColor = true;
            this.startPageBtn.Click += new System.EventHandler(this.startPageBtn_Click);
            // 
            // newPostBtn
            // 
            this.newPostBtn.Location = new System.Drawing.Point(441, 188);
            this.newPostBtn.Name = "newPostBtn";
            this.newPostBtn.Size = new System.Drawing.Size(115, 29);
            this.newPostBtn.TabIndex = 5;
            this.newPostBtn.Text = "Post";
            this.newPostBtn.UseVisualStyleBackColor = true;
            this.newPostBtn.Click += new System.EventHandler(this.newPostBtn_Click);
            // 
            // recentPostsLbl
            // 
            this.recentPostsLbl.AutoSize = true;
            this.recentPostsLbl.Location = new System.Drawing.Point(42, 344);
            this.recentPostsLbl.Name = "recentPostsLbl";
            this.recentPostsLbl.Size = new System.Drawing.Size(162, 20);
            this.recentPostsLbl.TabIndex = 6;
            this.recentPostsLbl.Text = "Recent Posts by Friends";
            // 
            // suggestedLbl
            // 
            this.suggestedLbl.AutoSize = true;
            this.suggestedLbl.Location = new System.Drawing.Point(74, 547);
            this.suggestedLbl.Name = "suggestedLbl";
            this.suggestedLbl.Size = new System.Drawing.Size(130, 20);
            this.suggestedLbl.TabIndex = 8;
            this.suggestedLbl.Text = "Suggested Friends";
            // 
            // newPostTxt
            // 
            this.newPostTxt.Location = new System.Drawing.Point(103, 189);
            this.newPostTxt.Multiline = true;
            this.newPostTxt.Name = "newPostTxt";
            this.newPostTxt.Size = new System.Drawing.Size(251, 128);
            this.newPostTxt.TabIndex = 10;
            this.newPostTxt.TabStop = false;
            this.newPostTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // suggestedListBox
            // 
            this.suggestedListBox.FormattingEnabled = true;
            this.suggestedListBox.ItemHeight = 20;
            this.suggestedListBox.Location = new System.Drawing.Point(250, 547);
            this.suggestedListBox.Name = "suggestedListBox";
            this.suggestedListBox.Size = new System.Drawing.Size(85, 104);
            this.suggestedListBox.TabIndex = 13;
            // 
            // allPostsTxt
            // 
            this.allPostsTxt.Location = new System.Drawing.Point(250, 344);
            this.allPostsTxt.Multiline = true;
            this.allPostsTxt.Name = "allPostsTxt";
            this.allPostsTxt.Size = new System.Drawing.Size(306, 143);
            this.allPostsTxt.TabIndex = 15;
            // 
            // addFriend
            // 
            this.addFriend.Location = new System.Drawing.Point(599, 584);
            this.addFriend.Name = "addFriend";
            this.addFriend.Size = new System.Drawing.Size(94, 29);
            this.addFriend.TabIndex = 16;
            this.addFriend.Text = "Add Friend";
            this.addFriend.UseVisualStyleBackColor = true;
            this.addFriend.Click += new System.EventHandler(this.addFriend_Click);
            // 
            // addFriendTxt
            // 
            this.addFriendTxt.Location = new System.Drawing.Point(450, 584);
            this.addFriendTxt.Name = "addFriendTxt";
            this.addFriendTxt.Size = new System.Drawing.Size(125, 27);
            this.addFriendTxt.TabIndex = 17;
            this.addFriendTxt.Text = "friend\'s name";
            // 
            // allFriendsList
            // 
            this.allFriendsList.FormattingEnabled = true;
            this.allFriendsList.ItemHeight = 20;
            this.allFriendsList.Location = new System.Drawing.Point(599, 344);
            this.allFriendsList.Name = "allFriendsList";
            this.allFriendsList.Size = new System.Drawing.Size(150, 104);
            this.allFriendsList.TabIndex = 18;
            this.allFriendsList.SelectedIndexChanged += new System.EventHandler(this.allFriendsList_SelectedIndexChanged);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 730);
            this.Controls.Add(this.allFriendsList);
            this.Controls.Add(this.addFriendTxt);
            this.Controls.Add(this.addFriend);
            this.Controls.Add(this.allPostsTxt);
            this.Controls.Add(this.suggestedListBox);
            this.Controls.Add(this.newPostTxt);
            this.Controls.Add(this.suggestedLbl);
            this.Controls.Add(this.recentPostsLbl);
            this.Controls.Add(this.newPostBtn);
            this.Controls.Add(this.startPageBtn);
            this.Controls.Add(this.userEmailTxt);
            this.Controls.Add(this.userNameTxt);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox userEmailTxt;
        private System.Windows.Forms.Button startPageBtn;
        private System.Windows.Forms.Button newPostBtn;
        private System.Windows.Forms.Label recentPostsLbl;
        private System.Windows.Forms.Label suggestedLbl;
        private System.Windows.Forms.TextBox newPostTxt;
        private System.Windows.Forms.ListBox suggestedListBox;
        private System.Windows.Forms.TextBox allPostsTxt;
        private System.Windows.Forms.Button addFriend;
        private System.Windows.Forms.TextBox addFriendTxt;
        private System.Windows.Forms.ListBox allFriendsList;
    }
}