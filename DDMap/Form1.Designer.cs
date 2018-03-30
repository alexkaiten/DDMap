namespace DDMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.loadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMap = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMap = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageArchetypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voice2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archetypeControl = new DDMap.ArchetypeCreationControl();
            this.mapControl = new DDMap.MapControl();
            this.mapCreationControl = new DDMap.MapCreationControl();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSaveToolStripMenuItem,
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1653, 28);
            this.menuStrip2.TabIndex = 5;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // loadSaveToolStripMenuItem
            // 
            this.loadSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMap,
            this.loadMap,
            this.saveToolStripMenuItem});
            this.loadSaveToolStripMenuItem.Name = "loadSaveToolStripMenuItem";
            this.loadSaveToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.loadSaveToolStripMenuItem.Text = "File";
            this.loadSaveToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.loadSaveToolStripMenuItem_DropDownItemClicked);
            // 
            // newMap
            // 
            this.newMap.Name = "newMap";
            this.newMap.Size = new System.Drawing.Size(117, 26);
            this.newMap.Text = "New";
            // 
            // loadMap
            // 
            this.loadMap.Name = "loadMap";
            this.loadMap.Size = new System.Drawing.Size(117, 26);
            this.loadMap.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageArchetypesToolStripMenuItem,
            this.voice2ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.menuToolStripMenuItem.Text = "Map";
            this.menuToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuToolStripMenuItem_DropDownItemClicked);
            // 
            // manageArchetypesToolStripMenuItem
            // 
            this.manageArchetypesToolStripMenuItem.Name = "manageArchetypesToolStripMenuItem";
            this.manageArchetypesToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.manageArchetypesToolStripMenuItem.Text = "Manage Characters";
            // 
            // voice2ToolStripMenuItem
            // 
            this.voice2ToolStripMenuItem.Name = "voice2ToolStripMenuItem";
            this.voice2ToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.voice2ToolStripMenuItem.Text = "Manage Map";
            // 
            // archetypeControl
            // 
            this.archetypeControl.Location = new System.Drawing.Point(16, 33);
            this.archetypeControl.Margin = new System.Windows.Forms.Padding(5);
            this.archetypeControl.Name = "archetypeControl";
            this.archetypeControl.Size = new System.Drawing.Size(1636, 688);
            this.archetypeControl.TabIndex = 8;
            // 
            // mapControl
            // 
            this.mapControl.BackColor = System.Drawing.Color.Transparent;
            this.mapControl.Location = new System.Drawing.Point(0, 33);
            this.mapControl.Margin = new System.Windows.Forms.Padding(5);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(1636, 688);
            this.mapControl.TabIndex = 6;
            // 
            // mapCreationControl
            // 
            this.mapCreationControl.Location = new System.Drawing.Point(3, 33);
            this.mapCreationControl.Margin = new System.Windows.Forms.Padding(5);
            this.mapCreationControl.Name = "mapCreationControl";
            this.mapCreationControl.Size = new System.Drawing.Size(1636, 688);
            this.mapCreationControl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDMap.Properties.Resources.carta_pergamena_21123451;
            this.ClientSize = new System.Drawing.Size(1653, 726);
            this.Controls.Add(this.mapCreationControl);
            this.Controls.Add(this.archetypeControl);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Map Manager";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voice2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMap;
        private System.Windows.Forms.ToolStripMenuItem loadMap;
        private MapControl mapControl;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private ArchetypeCreationControl archetypeControl;
        private System.Windows.Forms.ToolStripMenuItem manageArchetypesToolStripMenuItem;
        private MapCreationControl mapCreationControl;
    }
}

