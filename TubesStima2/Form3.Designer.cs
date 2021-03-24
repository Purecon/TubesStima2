
namespace TubesStima2
{
    partial class Form3
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
            this.backButton = new System.Windows.Forms.Button();
            this.comboBoxAcc = new System.Windows.Forms.ComboBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.listBoxFriend = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // comboBoxAcc
            // 
            this.comboBoxAcc.FormattingEnabled = true;
            this.comboBoxAcc.Location = new System.Drawing.Point(361, 44);
            this.comboBoxAcc.Name = "comboBoxAcc";
            this.comboBoxAcc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAcc.TabIndex = 9;
            this.comboBoxAcc.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcc_SelectedIndexChanged);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(240, 47);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(95, 13);
            this.labelAccount.TabIndex = 8;
            this.labelAccount.Text = "Choose Account : ";
            this.labelAccount.Click += new System.EventHandler(this.labelAccount_Click);
            // 
            // listBoxFriend
            // 
            this.listBoxFriend.FormattingEnabled = true;
            this.listBoxFriend.Location = new System.Drawing.Point(117, 83);
            this.listBoxFriend.Name = "listBoxFriend";
            this.listBoxFriend.Size = new System.Drawing.Size(559, 329);
            this.listBoxFriend.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFriend);
            this.Controls.Add(this.comboBoxAcc);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.backButton);
            this.Name = "Form3";
            this.Text = "Friend Recommendation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox comboBoxAcc;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.ListBox listBoxFriend;
    }
}