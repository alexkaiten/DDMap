using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDMap
{
    public partial class FantasyButton : UserControl
    {
        private Image Button() => Properties.Resources.Button; //Red-Brown button
        private Image HoveredButton() => Properties.Resources.ButtonHov; //Blue button
        private Image ClickedButton() => Properties.Resources.ButtonClicked; //Black-Whie button

        public FantasyButton()
        {
            InitializeComponent();
            this.Size = new Size(this.Button().Size.Width, this.Button().Size.Height);
            this.BackgroundImage = this.Button();
            this.MouseEnter += (sender, args) => this.BackgroundImage = this.HoveredButton();
            this.MouseLeave += (sender, args) => this.BackgroundImage = this.Button();
            this.MouseUp += (sender, args) => this.BackgroundImage = this.Button();
            this.MouseDown += (sender, args) => this.BackgroundImage = this.ClickedButton();
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            var Dimensions = e.ClipRectangle;
            SizeF s = g.MeasureString(this.Text, Font);
            g.DrawString(
                  this.Text,
                  this.Font, new SolidBrush(this.ForeColor),
                  Dimensions.Width / 2 - (s.Width / 2),
                  Dimensions.Y + 4
                  );
        }
    }
}
