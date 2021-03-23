
namespace TubesStima2
{
    partial class Testo
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExploreFriendButton = new System.Windows.Forms.Button();
            this.RecomFriendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ExploreFriendButton
            // 
            this.ExploreFriendButton.Location = new System.Drawing.Point(261, 104);
            this.ExploreFriendButton.Name = "ExploreFriendButton";
            this.ExploreFriendButton.Size = new System.Drawing.Size(236, 100);
            this.ExploreFriendButton.TabIndex = 2;
            this.ExploreFriendButton.Text = "Explore Friend";
            this.ExploreFriendButton.UseVisualStyleBackColor = true;
            this.ExploreFriendButton.Click += new System.EventHandler(this.ExploreFriend_Click);
            // 
            // RecomFriendButton
            // 
            this.RecomFriendButton.Location = new System.Drawing.Point(261, 238);
            this.RecomFriendButton.Name = "RecomFriendButton";
            this.RecomFriendButton.Size = new System.Drawing.Size(236, 100);
            this.RecomFriendButton.TabIndex = 3;
            this.RecomFriendButton.Text = "Friend Recommendation";
            this.RecomFriendButton.UseVisualStyleBackColor = true;
            this.RecomFriendButton.Click += new System.EventHandler(this.RecomFriendButton_Click);
            // 
            // Testo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecomFriendButton);
            this.Controls.Add(this.ExploreFriendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Testo";
            this.Text = "Tubes2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ExploreFriendButton;
        private System.Windows.Forms.Button RecomFriendButton;
    }
}

