﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;

namespace DDMap
{
    public partial class MapControl : UserControl
    {
        Image previousImage;
        PictureBox previousPictureBox;
        PictureBox currentPictureBox;
        public DataMap dataMap;
        List<Character> characterList = new List<Character>();
        ToolTip tip = new ToolTip();
        public Bitmap bmap;

        public MapControl()
        {
            InitializeComponent();
            mapBox.DragEnter += map_DragEnter;
            mapBox.DragOver += map_DragOver;
            mapBox.DragDrop += map_DragDrop;
            listBox1.DisplayMember = "CharacterName";
            listBox1.MouseDown += listBox1_MouseDown;
            listBox1.MouseMove += listBox1_MouseMove;
        }

        private Point mDownPos;
        void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mDownPos = e.Location;
        }
        void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            int index = listBox1.IndexFromPoint(e.Location);
            if (index < 0) return;
            if (Math.Abs(e.X - mDownPos.X) >= SystemInformation.DragSize.Width ||
                Math.Abs(e.Y - mDownPos.Y) >= SystemInformation.DragSize.Height)
                DoDragDrop(new DragObject(listBox1, listBox1.Items[index]), DragDropEffects.All);
        }

        void char_MouseDown(object sender, MouseEventArgs e)
        {
            mDownPos = e.Location;
        }
        void char_MouseMove(object sender, MouseEventArgs e)
        {
            Panel b = (Panel)(sender);
            try
            {
                Character c = dataMap.Characters.Where(t => t.CurrentPanel != null && t.CurrentPanel.Location == b.Location).FirstOrDefault();
                if (e.Button != MouseButtons.Left) return;
                if (Math.Abs(e.X - mDownPos.X) >= SystemInformation.DragSize.Width ||
                    Math.Abs(e.Y - mDownPos.Y) >= SystemInformation.DragSize.Height)
                    DoDragDrop(new DragObject(listBox1, c), DragDropEffects.All);
            }
            catch { }
        }

        private void map_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                Point pt = mapBox.PointToClient(new Point(e.X, e.Y));
                PictureBox p = (PictureBox)(mapBox.GetChildAtPoint(pt));
                highlightPicture(p);
                currentPictureBox = p;
            }
            catch { }
            e.Effect = DragDropEffects.All;
        }



        private void map_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                Point pt = mapBox.PointToClient(new Point(e.X, e.Y));
                PictureBox p = (PictureBox)(mapBox.GetChildAtPoint(pt));
                if (!p.Equals(currentPictureBox))
                {
                    previousPictureBox = currentPictureBox;
                    highlightPicture(p);
                    currentPictureBox = p;
                }
            }
            catch { }

        }

        private void map_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Point pt = mapBox.PointToClient(new Point(e.X, e.Y));
                PictureBox p = (PictureBox)(mapBox.GetChildAtPoint(pt));
                restoreCurrentPicture();
                DragObject obj = (DragObject)e.Data.GetData(typeof(DragObject));
                Character c = (Character)obj.item;
                InsertCharacter(c, pt);

            }
            catch { }

        }


        private void highlightPicture(PictureBox p)
        {
            if (previousPictureBox != null && previousImage != null)
            {
                previousPictureBox.Image = previousImage;
            }

            if (p != null)
            {
                previousImage = p.Image;
                p.Image = GenerateFilteredImage(new Bitmap(p.Image), Color.Red);
            }

        }

        private void restoreCurrentPicture()
        {
            currentPictureBox.Image = previousImage;
            currentPictureBox = null;
            previousPictureBox = null;
            previousImage = null;
        }



        private class DragObject
        {
            public ListBox source;
            public object item;
            public DragObject(ListBox box, object data) { source = box; item = data; }
        }

        private void loadbox()
        {
            int tileWidth = dataMap.CellSize;
            int tileHeight = dataMap.CellSize;
            int tileRows = mapBox.Height / dataMap.CellSize;
            int tileCols = mapBox.Width / dataMap.CellSize;
            mapBox.Controls.Clear();
            

            using (Bitmap sourceBmp = new Bitmap(bmap))
            {
                Size s = new Size(tileWidth, tileHeight);
                Rectangle destRect = new Rectangle(Point.Empty, s);
                for (int row = 0; row < tileRows; row++)
                    for (int col = 0; col < tileCols; col++)
                    {
                        PictureBox p = new PictureBox();
                        p.BorderStyle = BorderStyle.FixedSingle;
                        p.Size = s;
                        Point loc = new Point(tileWidth * col, tileHeight * row);
                        Rectangle srcRect = new Rectangle(loc, s);
                        Bitmap tile = new Bitmap(tileWidth, tileHeight);
                        Graphics G = Graphics.FromImage(tile);
                        G.DrawImage(sourceBmp, destRect, srcRect, GraphicsUnit.Pixel);
                        p.Image = tile;
                        p.Location = loc;
                        p.Tag = loc;
                        p.Name = String.Format("Col={0:00}-Row={1:00}", col, row);
                        mapBox.Controls.Add(p);
                    }
            }
            foreach (Character c in dataMap.Characters)
            {
                if (c.Position.X > -1 && c.Position.Y > -1)
                {
                    DrawCharacter(c, c.Position);
                }
            }
            fillCharactersList();

        }

        private void fillCharactersList()
        {
            listBox1.Items.Clear();
            foreach (Character c in dataMap.Characters)
            {
                listBox1.Items.Add(c);
            }
        }

        private Bitmap GenerateFilteredImage(Bitmap bmp, Color color)
        {
            Bitmap bmap = (Bitmap)bmp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    Color pixelColor = bmap.GetPixel(i, j);
                    int nPixelR = color.R;
                    int nPixelG = color.G;
                    int nPixelB = color.B;

                    nPixelR = Math.Max(pixelColor.R, nPixelR);

                    nPixelG = Math.Max(pixelColor.G, nPixelG);

                    nPixelB = Math.Max(pixelColor.B, nPixelB);

                    bmap.SetPixel(i, j, Color.FromArgb(90, (byte)nPixelR,
                      (byte)nPixelG, (byte)nPixelB));
                }
            }
            return (Bitmap)bmap.Clone();
        }



        private void fillListBox()
        {
            Character c1 = new Character("Test1", 100, "goblin", Common.DDSize.Media);
            Character c2 = new Character("Test2", 150, "goblin", Common.DDSize.Colossale);
            dataMap.Characters.Add(c1);
            dataMap.Characters.Add(c2);
            foreach (Character c in dataMap.Characters)
            {
                listBox1.Items.Add(c);
            }
        }

        private void InsertCharacter(Character c, Point position)
        {
            //MapSquare mapSquare = dataMap.Squares[p.Name];
            //p.Image = DrawCharacter(p, c, position);
            Panel b = new Panel();
            //b.Text = " ";
            b.Size = new Size(10, 10);
            Point center = new Point(position.X - (b.Size.Height / 2), position.Y - (b.Size.Width / 2));
            b.Location = center;
            b.BackColor = c.Colour;
            b.MouseHover += ShowTooltip;
            b.MouseLeave += HideTooltip;
            b.MouseDown += char_MouseDown;
            b.MouseMove += char_MouseMove;
            b.MouseClick += char_MouseClick;
            if (mapBox.Controls.Contains(c.CurrentPanel))
            {
                mapBox.Controls.Remove(c.CurrentPanel);
            }
            mapBox.Controls.Add(b);
            b.BringToFront();
            c.CurrentPanel = b;
        }

        

        private void DrawCharacter(Character c, Point position)
        {
            //MapSquare mapSquare = dataMap.Squares[p.Name];
            //p.Image = DrawCharacter(p, c, position);
            Panel b = new Panel();
            //b.Text = " ";
            b.Size = new Size(10, 10);
            b.Location = position;
            b.BackColor = c.Colour;
            b.MouseHover += ShowTooltip;
            b.MouseLeave += HideTooltip;
            b.MouseDown += char_MouseDown;
            b.MouseMove += char_MouseMove;
            b.MouseClick += char_MouseClick;
            c.CurrentPanel = b;
            mapBox.Controls.Add(b);
            b.BringToFront();
        }

        private void char_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ShowMyDialogBox(sender);
            }
        }

        private void ShowMyDialogBox(object sender)
        {
            Panel b = (Panel)(sender);
            //PictureBox p = (PictureBox)b.Parent;
            //MapSquare mapSquare = dataMap.Squares[p.Name];
            using (DialogForm dialog = new DialogForm())
            {
                try
                {
                    Character c = dataMap.Characters.Where(t => t.CurrentPanel != null && t.CurrentPanel.Location == b.Location).FirstOrDefault();


                    dialog.SetCharacter(c);
                    if (dialog.ShowDialog(this) == DialogResult.Yes)
                    {
                        Character modifiedCharacter = dialog.GetModifiedCharacter();
                        c.CopyCharacter(modifiedCharacter);
                    }
                    else
                    {
                        //MessageBox.Show("Cancelled");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void ShowTooltip(object sender, EventArgs e)
        {
            try
            {
                Panel b = (Panel)sender;
                Character c = dataMap.Characters.Where(x => x.CurrentPanel != null && x.CurrentPanel.Location == b.Location).FirstOrDefault();
                StringBuilder sb = new StringBuilder();
                sb.Append("\n");
                sb.Append("Nome: " + c.Name + "\n");
                sb.Append("PF: " + c.PF + "\n");
                tip.Show(sb.ToString(), b);
            }
            catch { }
        }

        private void HideTooltip(object sender, EventArgs e)
        {
            Panel b = (Panel)sender;
            tip.Hide(b);
        }

        public void UpdateMap()
        {
            loadbox();
        }

        public void UpdateCharacterList()
        {
            fillCharactersList();
        }
    }
}