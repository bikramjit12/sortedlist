namespace sortedlist
{
    partial class Form1
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
            this.lbxRunnerList = new System.Windows.Forms.ListBox();
            this.btnLoadRunner = new System.Windows.Forms.Button();
            this.txtNewMember = new System.Windows.Forms.TextBox();
            this.btnAddRunners = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxRunnerList
            // 
            this.lbxRunnerList.FormattingEnabled = true;
            this.lbxRunnerList.Location = new System.Drawing.Point(75, 32);
            this.lbxRunnerList.Name = "lbxRunnerList";
            this.lbxRunnerList.Size = new System.Drawing.Size(206, 212);
            this.lbxRunnerList.TabIndex = 0;
            // 
            // btnLoadRunner
            // 
            this.btnLoadRunner.Location = new System.Drawing.Point(408, 38);
            this.btnLoadRunner.Name = "btnLoadRunner";
            this.btnLoadRunner.Size = new System.Drawing.Size(240, 23);
            this.btnLoadRunner.TabIndex = 1;
            this.btnLoadRunner.Text = "Load Runner";
            this.btnLoadRunner.UseVisualStyleBackColor = true;
            this.btnLoadRunner.Click += new System.EventHandler(this.btnLoadRunner_Click);
            // 
            // txtNewMember
            // 
            this.txtNewMember.Location = new System.Drawing.Point(408, 173);
            this.txtNewMember.Name = "txtNewMember";
            this.txtNewMember.Size = new System.Drawing.Size(240, 20);
            this.txtNewMember.TabIndex = 2;
            // 
            // btnAddRunners
            // 
            this.btnAddRunners.Location = new System.Drawing.Point(408, 221);
            this.btnAddRunners.Name = "btnAddRunners";
            this.btnAddRunners.Size = new System.Drawing.Size(240, 23);
            this.btnAddRunners.TabIndex = 3;
            this.btnAddRunners.Text = "Add New Runner";
            this.btnAddRunners.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add New Member";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRunners);
            this.Controls.Add(this.txtNewMember);
            this.Controls.Add(this.btnLoadRunner);
            this.Controls.Add(this.lbxRunnerList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRunnerList;
        private System.Windows.Forms.Button btnLoadRunner;
        private System.Windows.Forms.TextBox txtNewMember;
        private System.Windows.Forms.Button btnAddRunners;
        private System.Windows.Forms.Label label1;
    }
}

