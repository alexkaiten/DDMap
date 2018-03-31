namespace DDMap
{
    partial class MapCreationControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mapBox = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.MapNameLabel = new System.Windows.Forms.Label();
            this.mapNameTextBox = new System.Windows.Forms.TextBox();
            this.CellNumberLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.loadImageBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapBox
            // 
            this.mapBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapBox.Location = new System.Drawing.Point(549, 7);
            this.mapBox.Margin = new System.Windows.Forms.Padding(4);
            this.mapBox.Name = "mapBox";
            this.mapBox.Size = new System.Drawing.Size(1066, 664);
            this.mapBox.TabIndex = 6;
            this.mapBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mapBox_Paint);
            // 
            // leftPanel
            // 
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel.Controls.Add(this.loadImageBtn);
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.cancelBtn);
            this.leftPanel.Controls.Add(this.MapNameLabel);
            this.leftPanel.Controls.Add(this.mapNameTextBox);
            this.leftPanel.Controls.Add(this.CellNumberLabel);
            this.leftPanel.Controls.Add(this.trackBar1);
            this.leftPanel.Location = new System.Drawing.Point(16, 7);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(513, 664);
            this.leftPanel.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(296, 622);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 28);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(48, 622);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(149, 28);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // MapNameLabel
            // 
            this.MapNameLabel.AutoSize = true;
            this.MapNameLabel.Location = new System.Drawing.Point(1, 70);
            this.MapNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MapNameLabel.Name = "MapNameLabel";
            this.MapNameLabel.Size = new System.Drawing.Size(76, 17);
            this.MapNameLabel.TabIndex = 3;
            this.MapNameLabel.Text = "Map Name";
            // 
            // mapNameTextBox
            // 
            this.mapNameTextBox.Location = new System.Drawing.Point(5, 103);
            this.mapNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mapNameTextBox.Name = "mapNameTextBox";
            this.mapNameTextBox.Size = new System.Drawing.Size(500, 22);
            this.mapNameTextBox.TabIndex = 2;
            // 
            // CellNumberLabel
            // 
            this.CellNumberLabel.AutoSize = true;
            this.CellNumberLabel.Location = new System.Drawing.Point(1, 326);
            this.CellNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CellNumberLabel.Name = "CellNumberLabel";
            this.CellNumberLabel.Size = new System.Drawing.Size(85, 17);
            this.CellNumberLabel.TabIndex = 1;
            this.CellNumberLabel.Text = "Cell Number";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(5, 372);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(501, 56);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.Value = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // loadImageBtn
            // 
            this.loadImageBtn.Location = new System.Drawing.Point(5, 213);
            this.loadImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadImageBtn.Name = "loadImageBtn";
            this.loadImageBtn.Size = new System.Drawing.Size(133, 28);
            this.loadImageBtn.TabIndex = 6;
            this.loadImageBtn.Text = "Load Image";
            this.loadImageBtn.UseVisualStyleBackColor = true;
            this.loadImageBtn.Click += new System.EventHandler(this.loadImageBtn_Click);
            // 
            // MapCreationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mapBox);
            this.Controls.Add(this.leftPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MapCreationControl";
            this.Size = new System.Drawing.Size(1636, 688);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mapBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label MapNameLabel;
        private System.Windows.Forms.TextBox mapNameTextBox;
        private System.Windows.Forms.Label CellNumberLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button loadImageBtn;
    }
}
