
namespace Social_Book
{
    partial class InfectionPage
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
            this.infectionTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // infectionTxt
            // 
            this.infectionTxt.Location = new System.Drawing.Point(145, 34);
            this.infectionTxt.Multiline = true;
            this.infectionTxt.Name = "infectionTxt";
            this.infectionTxt.Size = new System.Drawing.Size(521, 349);
            this.infectionTxt.TabIndex = 0;
            this.infectionTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InfectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infectionTxt);
            this.Name = "InfectionPage";
            this.Text = "InfectionPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infectionTxt;
    }
}