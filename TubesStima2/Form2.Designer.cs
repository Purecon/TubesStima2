
namespace TubesStima2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.back_button = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.checkBoxBFS = new System.Windows.Forms.CheckBox();
            this.checkBoxDFS = new System.Windows.Forms.CheckBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelTarget = new System.Windows.Forms.Label();
            this.comboBoxAcc = new System.Windows.Forms.ComboBox();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.labelTitleDerajat = new System.Windows.Forms.Label();
            this.labelDerajatKoneksi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gViewer1
            // 
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(12, 76);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(776, 350);
            this.gViewer1.TabIndex = 0;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            this.gViewer1.Load += new System.EventHandler(this.gViewer1_Load);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(598, 26);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Submit";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // checkBoxBFS
            // 
            this.checkBoxBFS.AutoSize = true;
            this.checkBoxBFS.Checked = true;
            this.checkBoxBFS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBFS.Location = new System.Drawing.Point(206, 32);
            this.checkBoxBFS.Name = "checkBoxBFS";
            this.checkBoxBFS.Size = new System.Drawing.Size(46, 17);
            this.checkBoxBFS.TabIndex = 3;
            this.checkBoxBFS.Text = "BFS";
            this.checkBoxBFS.UseVisualStyleBackColor = true;
            this.checkBoxBFS.CheckedChanged += new System.EventHandler(this.checkBoxBFS_CheckedChanged);
            // 
            // checkBoxDFS
            // 
            this.checkBoxDFS.AutoSize = true;
            this.checkBoxDFS.Location = new System.Drawing.Point(280, 32);
            this.checkBoxDFS.Name = "checkBoxDFS";
            this.checkBoxDFS.Size = new System.Drawing.Size(47, 17);
            this.checkBoxDFS.TabIndex = 4;
            this.checkBoxDFS.Text = "DFS";
            this.checkBoxDFS.UseVisualStyleBackColor = true;
            this.checkBoxDFS.CheckedChanged += new System.EventHandler(this.checkBoxDFS_CheckedChanged);
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(350, 20);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(95, 13);
            this.labelAccount.TabIndex = 5;
            this.labelAccount.Text = "Choose Account : ";
            this.labelAccount.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Location = new System.Drawing.Point(350, 46);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(113, 13);
            this.labelTarget.TabIndex = 6;
            this.labelTarget.Text = "Explore Friends With : ";
            // 
            // comboBoxAcc
            // 
            this.comboBoxAcc.FormattingEnabled = true;
            this.comboBoxAcc.Location = new System.Drawing.Point(471, 17);
            this.comboBoxAcc.Name = "comboBoxAcc";
            this.comboBoxAcc.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAcc.TabIndex = 7;
            this.comboBoxAcc.SelectedIndexChanged += new System.EventHandler(this.comboBoxAcc_SelectedIndexChanged);
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(471, 43);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTarget.TabIndex = 8;
            this.comboBoxTarget.SelectedIndexChanged += new System.EventHandler(this.comboBoxTarget_SelectedIndexChanged);
            // 
            // labelTitleDerajat
            // 
            this.labelTitleDerajat.AutoSize = true;
            this.labelTitleDerajat.Location = new System.Drawing.Point(693, 17);
            this.labelTitleDerajat.Name = "labelTitleDerajat";
            this.labelTitleDerajat.Size = new System.Drawing.Size(87, 13);
            this.labelTitleDerajat.TabIndex = 9;
            this.labelTitleDerajat.Text = "Derajat koneksi: ";
            // 
            // labelDerajatKoneksi
            // 
            this.labelDerajatKoneksi.AutoSize = true;
            this.labelDerajatKoneksi.Location = new System.Drawing.Point(726, 43);
            this.labelDerajatKoneksi.Name = "labelDerajatKoneksi";
            this.labelDerajatKoneksi.Size = new System.Drawing.Size(0, 13);
            this.labelDerajatKoneksi.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDerajatKoneksi);
            this.Controls.Add(this.labelTitleDerajat);
            this.Controls.Add(this.comboBoxTarget);
            this.Controls.Add(this.comboBoxAcc);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.checkBoxDFS);
            this.Controls.Add(this.checkBoxBFS);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.gViewer1);
            this.Name = "Form2";
            this.Text = "ExploreFriends";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox checkBoxBFS;
        private System.Windows.Forms.CheckBox checkBoxDFS;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.ComboBox comboBoxAcc;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Label labelTitleDerajat;
        private System.Windows.Forms.Label labelDerajatKoneksi;
    }
}