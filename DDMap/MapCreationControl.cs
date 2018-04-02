using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace DDMap
{
    public partial class MapCreationControl : UserControl
    {
        Bitmap bmap;
        public MapCreationControl()
        {
            InitializeComponent();
            this.loadImageBtn.Text = "Load Image";
            this.cancelBtn.Text = "Cancel";
            this.saveBtn.Text = "Save";
        }

        private void loadImageBtn_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = Common.AllImages + "|" + Common.AllFiles;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            if (Path.GetExtension(openFileDialog1.FileName) == ".png" ||
                                Path.GetExtension(openFileDialog1.FileName) == ".jpg" ||
                                Path.GetExtension(openFileDialog1.FileName) == ".jpeg" ||
                                Path.GetExtension(openFileDialog1.FileName) == ".jfif" ||
                                Path.GetExtension(openFileDialog1.FileName) == ".bmp" ||
                                Path.GetExtension(openFileDialog1.FileName) == ".tif" ||
                                Path.GetExtension(openFileDialog1.FileName) == ".tiff" ||
                                Path.GetExtension(openFileDialog1.FileName) == ".gif")
                            {
                                if (openFileDialog1.FileName != String.Empty)
                                {
                                    bmap = resizeImage(new Bitmap(openFileDialog1.FileName), mapBox.Width, mapBox.Height);
                                    mapBox.BackgroundImage = bmap;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        //private void generateGrid(int cellSize)
        //{
        //    using (Graphics g = this.gridPictureBox.CreateGraphics())
        //    {
        //        Pen p = new Pen(Color.Black);

        //        for (int y = 0; y < mapBox.Height; y += cellSize)
        //        {
        //            for (int x = 0; x < mapBox.Width; x += cellSize)
        //            {
        //                g.DrawLine(p, 0, y, x, y);
        //                g.DrawLine(p, x, 0, x, y);
        //            }
        //        }
        //    }
        //}


        private Bitmap resizeImage(Bitmap imageToReduce, int canvasWidth, int canvasHeight)
        {
            Image image = (Image)imageToReduce;

            System.Drawing.Image thumbnail =
                new Bitmap(canvasWidth, canvasHeight); // changed parm names
            System.Drawing.Graphics graphic =
                         System.Drawing.Graphics.FromImage(thumbnail);

            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;

            /* ------------------ new code --------------- */

            // Figure out the ratio
            double ratioX = (double)canvasWidth / (double)imageToReduce.Width;
            double ratioY = (double)canvasHeight / (double)imageToReduce.Height;
            // use whichever multiplier is smaller
            double ratio = ratioX < ratioY ? ratioX : ratioY;

            // now we can get the new height and width
            int newHeight = Convert.ToInt32(imageToReduce.Height * ratio);
            int newWidth = Convert.ToInt32(imageToReduce.Width * ratio);

            // Now calculate the X,Y position of the upper-left corner 
            // (one of these will always be zero)
            int posX = Convert.ToInt32((canvasWidth - (imageToReduce.Width * ratio)) / 2);
            int posY = Convert.ToInt32((canvasHeight - (imageToReduce.Height * ratio)) / 2);

            graphic.Clear(Color.White); // white padding
            graphic.DrawImage(image, posX, posY, newWidth, newHeight);

            /* ------------- end new code ---------------- */

            return new Bitmap(thumbnail);
        }
        

        private void mapBox_Paint(object sender, PaintEventArgs e)
        {
            int cellSize = mapBox.Width / trackBar1.Value;
            using (Graphics g = e.Graphics)
            {
                Pen p = new Pen(Color.Black, 2);

                for (int y = 0; y < mapBox.Height; y += cellSize)
                {
                    g.DrawLine(p, 0, y, mapBox.Width, y);
                }
                for (int x = 0; x < mapBox.Width; x += cellSize)
                {
                    g.DrawLine(p, x, 0, x, mapBox.Height);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int cellSize = mapBox.Width / trackBar1.Value;
            if (mapNameTextBox.Text != string.Empty && bmap != null)
            {
                ((Form1)this.Parent).NewMap(mapNameTextBox.Text, bmap, cellSize);
            }
            else
            {
                MessageBox.Show("Please insert a name and an image for the map.");
            }
            if (mapNameTextBox.Text != string.Empty && bmap != null)
            {
                resetFields();
            }

        }

        private void resetFields()
        {
            trackBar1.Value = 15;
            mapBox.BackgroundImage = null;
            bmap = null;
            mapNameTextBox.Text = string.Empty;
        }

        private void trackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            mapBox.Invalidate();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            resetFields();
            mapBox.Invalidate();
        }
    }
}
