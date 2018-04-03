namespace DDMap
{
    partial class MapControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapControl));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mapBox = new System.Windows.Forms.Panel();
            this.projectBtn = new DDMap.FantasyButton();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(190, 559);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.projectBtn);
            this.rightPanel.Controls.Add(this.listBox1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1027, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(200, 559);
            this.rightPanel.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 225);
            this.listBox1.TabIndex = 0;
            this.listBox1.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.listBox1_GiveFeedback);
            // 
            // mapBox
            // 
            this.mapBox.AllowDrop = true;
            this.mapBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapBox.Location = new System.Drawing.Point(208, 3);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(800, 540);
            this.mapBox.TabIndex = 3;
            this.mapBox.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.mapBox_GiveFeedback);
            this.mapBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mapBox_Paint);
            // 
            // projectBtn
            // 
            this.projectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("projectBtn.BackgroundImage")));
            this.projectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projectBtn.ForeColor = System.Drawing.Color.White;
            this.projectBtn.Location = new System.Drawing.Point(34, 512);
            this.projectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.projectBtn.Name = "projectBtn";
            this.projectBtn.Size = new System.Drawing.Size(130, 30);
            this.projectBtn.TabIndex = 1;
            this.projectBtn.Click += new System.EventHandler(this.projectBtn_Click);
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.leftPanel);
            this.Name = "MapControl";
            this.Size = new System.Drawing.Size(1227, 559);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel mapBox;
        private FantasyButton projectBtn;
    }
}
