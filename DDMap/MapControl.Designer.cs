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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mapBox = new System.Windows.Forms.Panel();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(253, 688);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.listBox1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1370, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(266, 688);
            this.rightPanel.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 30);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(219, 276);
            this.listBox1.TabIndex = 0;
            // 
            // mapBox
            // 
            this.mapBox.AllowDrop = true;
            this.mapBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapBox.Location = new System.Drawing.Point(277, 4);
            this.mapBox.Margin = new System.Windows.Forms.Padding(4);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(1066, 664);
            this.mapBox.TabIndex = 3;
            // 
            // MapControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.leftPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapControl";
            this.Size = new System.Drawing.Size(1636, 688);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel mapBox;
    }
}
