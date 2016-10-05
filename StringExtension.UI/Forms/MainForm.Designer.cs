namespace StringExtension.UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miSystemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.btnGetIndexes = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtSubtext = new System.Windows.Forms.TextBox();
            this.lblSubtext = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnPopulateTestData = new System.Windows.Forms.Button();
            this.msMainMenu.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(584, 24);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "Main Menu";
            // 
            // miSystem
            // 
            this.miSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystemExit});
            this.miSystem.Name = "miSystem";
            this.miSystem.Size = new System.Drawing.Size(57, 20);
            this.miSystem.Text = "System";
            // 
            // miSystemExit
            // 
            this.miSystemExit.Image = global::StringExtension.UI.Properties.Resources.icoExit;
            this.miSystemExit.Name = "miSystemExit";
            this.miSystemExit.Size = new System.Drawing.Size(152, 22);
            this.miSystemExit.Text = "Exit";
            this.miSystemExit.Click += new System.EventHandler(this.miSystemExit_Click);
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblOutput);
            this.gbMain.Controls.Add(this.txtOutput);
            this.gbMain.Controls.Add(this.lblSubtext);
            this.gbMain.Controls.Add(this.txtSubtext);
            this.gbMain.Controls.Add(this.lblText);
            this.gbMain.Controls.Add(this.txtText);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMain.Location = new System.Drawing.Point(0, 24);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(584, 100);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            // 
            // btnGetIndexes
            // 
            this.btnGetIndexes.Location = new System.Drawing.Point(497, 130);
            this.btnGetIndexes.Name = "btnGetIndexes";
            this.btnGetIndexes.Size = new System.Drawing.Size(75, 23);
            this.btnGetIndexes.TabIndex = 2;
            this.btnGetIndexes.Text = "Get Indexes";
            this.btnGetIndexes.UseVisualStyleBackColor = true;
            this.btnGetIndexes.Click += new System.EventHandler(this.btnGetIndexes_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(64, 19);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(508, 20);
            this.txtText.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 22);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text:";
            // 
            // txtSubtext
            // 
            this.txtSubtext.Location = new System.Drawing.Point(64, 45);
            this.txtSubtext.Name = "txtSubtext";
            this.txtSubtext.Size = new System.Drawing.Size(508, 20);
            this.txtSubtext.TabIndex = 2;
            // 
            // lblSubtext
            // 
            this.lblSubtext.AutoSize = true;
            this.lblSubtext.Location = new System.Drawing.Point(12, 48);
            this.lblSubtext.Name = "lblSubtext";
            this.lblSubtext.Size = new System.Drawing.Size(46, 13);
            this.lblSubtext.TabIndex = 3;
            this.lblSubtext.Text = "Subtext:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(64, 71);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(508, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 74);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Output:";
            // 
            // btnPopulateTestData
            // 
            this.btnPopulateTestData.Location = new System.Drawing.Point(366, 130);
            this.btnPopulateTestData.Name = "btnPopulateTestData";
            this.btnPopulateTestData.Size = new System.Drawing.Size(125, 23);
            this.btnPopulateTestData.TabIndex = 3;
            this.btnPopulateTestData.Text = "Populate Test Data";
            this.btnPopulateTestData.UseVisualStyleBackColor = true;
            this.btnPopulateTestData.Click += new System.EventHandler(this.btnPopulateTestData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.btnPopulateTestData);
            this.Controls.Add(this.btnGetIndexes);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miSystemExit;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblSubtext;
        private System.Windows.Forms.TextBox txtSubtext;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Button btnGetIndexes;
        private System.Windows.Forms.Button btnPopulateTestData;
    }
}