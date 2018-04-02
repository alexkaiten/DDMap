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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapCreationControl));
            this.mapBox = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.MapNameLabel = new System.Windows.Forms.Label();
            this.mapNameTextBox = new System.Windows.Forms.TextBox();
            this.CellNumberLabel = new System.Windows.Forms.Label();
            this.saveBtn = new DDMap.FantasyButton();
            this.cancelBtn = new DDMap.FantasyButton();
            this.loadImageBtn = new DDMap.FantasyButton();
            this.trackBar1 = new MB.Controls.ColorSlider();
            this.leftPanel.SuspendLayout();
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
            this.leftPanel.Controls.Add(this.trackBar1);
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.cancelBtn);
            this.leftPanel.Controls.Add(this.loadImageBtn);
            this.leftPanel.Controls.Add(this.MapNameLabel);
            this.leftPanel.Controls.Add(this.mapNameTextBox);
            this.leftPanel.Controls.Add(this.CellNumberLabel);
            this.leftPanel.Location = new System.Drawing.Point(16, 7);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(513, 664);
            this.leftPanel.TabIndex = 4;
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
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(318, 612);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 30);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(61, 612);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 30);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loadImageBtn
            // 
            this.loadImageBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadImageBtn.BackgroundImage")));
            this.loadImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadImageBtn.ForeColor = System.Drawing.Color.White;
            this.loadImageBtn.Location = new System.Drawing.Point(5, 214);
            this.loadImageBtn.Name = "loadImageBtn";
            this.loadImageBtn.Size = new System.Drawing.Size(130, 30);
            this.loadImageBtn.TabIndex = 7;
            this.loadImageBtn.Click += new System.EventHandler(this.loadImageBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Transparent;
            this.trackBar1.BarInnerColor = System.Drawing.Color.Red;
            this.trackBar1.BarOuterColor = System.Drawing.Color.Black;
            this.trackBar1.BarPenColor = System.Drawing.Color.Black;
            this.trackBar1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackBar1.DrawFocusRectangle = false;
            this.trackBar1.ElapsedInnerColor = System.Drawing.Color.Red;
            this.trackBar1.ElapsedOuterColor = System.Drawing.Color.Black;
            this.trackBar1.LargeChange = ((uint)(5u));
            this.trackBar1.Location = new System.Drawing.Point(5, 355);
            this.trackBar1.Maximum = 25;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(500, 30);
            this.trackBar1.SmallChange = ((uint)(2u));
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Text = "colorSlider1";
            this.trackBar1.ThumbInnerColor = System.Drawing.Color.DarkOrange;
            this.trackBar1.ThumbOuterColor = System.Drawing.Color.Gold;
            this.trackBar1.ThumbPenColor = System.Drawing.Color.Black;
            this.trackBar1.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.trackBar1.Value = 15;
            this.trackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar1_Scroll);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mapBox;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label MapNameLabel;
        private System.Windows.Forms.TextBox mapNameTextBox;
        private System.Windows.Forms.Label CellNumberLabel;
        private FantasyButton saveBtn;
        private FantasyButton cancelBtn;
        private FantasyButton loadImageBtn;
        private MB.Controls.ColorSlider trackBar1;
    }
}
