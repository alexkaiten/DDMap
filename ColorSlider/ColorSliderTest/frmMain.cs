using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MB.Controls;

namespace ColorSliderTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //set semitransparent color for one slider
            colorSlider4.BackColor = Color.FromArgb(100, Color.BlueViolet);

            //assign custom thumb shapes
            const string text = "ColorSlider";
            GraphicsPath gp1 = new GraphicsPath();            
            gp1.AddString(text, FontFamily.GenericSerif, (int)FontStyle.Bold, colorSliderCustomThumbText.Height, new Point(0,0), StringFormat.GenericDefault);            
            colorSliderCustomThumbText.ThumbCustomShape = gp1;  
            
            GraphicsPath gp2 = new GraphicsPath();
            Size s = new Size(colorSliderCustomThumbTrackBar.ThumbSize, colorSliderCustomThumbTrackBar.Height * 9 / 10);            
            gp2.AddPolygon(new Point[] { 
                               new Point(0, 0),
                               new Point(s.Width, 0),
                               new Point(s.Width, s.Height * 4 / 5),
                               new Point(s.Width / 2, s.Height),
                               new Point(0, s.Height * 4 / 5)
                           });            
            colorSliderCustomThumbTrackBar.ThumbCustomShape = gp2;  

            GraphicsPath gp3 = new GraphicsPath();
            const int iNumRevs   = 7;
            int       iNumPoints = iNumRevs * 2 * (s.Width + s.Height);            
            float     fAngle, fScale;
            s = new Size(colorSliderCustomThumbSpiral.ThumbSize, colorSliderCustomThumbSpiral.Height * 9 / 10);                        
            PointF lastP = new PointF(s.Width, s.Height / 2);
            PointF currP;
            for (int i = 0; i < iNumPoints; i++)
            {
                fAngle = (float)(i * 2 * Math.PI /(iNumPoints / iNumRevs));
                fScale = 1 - (float)i / iNumPoints;                
                currP = new PointF((float)(s.Width / 2 * (1 + fScale * Math.Cos(fAngle))),
                                   (float)(s.Height / 2 * (1 + fScale * Math.Sin(fAngle))));
                gp3.AddLine(lastP, currP);
                lastP = currP;
            }          
            colorSliderCustomThumbSpiral.ThumbCustomShape = gp3;
            
            GraphicsPath gp4;
            s = new Size(colorSliderCustomThumbStar.ThumbSize, colorSliderCustomThumbStar.Height * 9 / 10);                        
            Point[] ap = new Point[5];
            byte[] b = new byte[ap.Length];
            for (int i = 0; i < ap.Length; i++)
            {
                double dAngle = (i * 0.8 - 0.5) * Math.PI;
                ap[i].X = (int)(s.Width * (0.50 + 0.48 * Math.Cos(dAngle)));
                ap[i].Y = (int)(s.Height * (0.50 + 0.48 * Math.Sin(dAngle)));
                b[i] = (byte) PathPointType.Line;
            }
            gp4 = new GraphicsPath(ap, b);
            gp4.CloseAllFigures();
            gp4.FillMode = FillMode.Winding;            
            colorSliderCustomThumbStar.ThumbCustomShape = gp4;

            GraphicsPath gp5;
            s = new Size(colorSliderCustomThumbSinus.ThumbSize, colorSliderCustomThumbSinus.Height * 9 / 10);                        
            PointF[] apf = new PointF[s.Width * 2];
            b = new byte[apf.Length];
            for (int i = 0; i < s.Width; i++)
            {
                apf[i].X = i;
                apf[i].Y = s.Height / 2 * (1 - (float) 
                                   Math.Sin(i * 2 * Math.PI / (s.Width - 1))) - 2;
                b[i] = (byte) PathPointType.Line;
            }
            for (int i = s.Width; i < s.Width * 2 ; i++)
            {
                apf[i].X = s.Width * 2 - i;
                apf[i].Y = s.Height / 2 * (1 - (float)
                                   Math.Sin(-i * 2 * Math.PI / (s.Width - 1))) + 2;
                b[i] = (byte)PathPointType.Line;
            }
            gp5 = new GraphicsPath(apf, b);
            gp5.CloseAllFigures();
            gp5.FillMode = FillMode.Winding;            
            colorSliderCustomThumbSinus.ThumbCustomShape = gp5;
        }

        private void SlidersScroll(object sender, ScrollEventArgs e)
        {
            if (cbEventLog.Checked)
            {
                edEventLog.Text = String.Format("{0}, Scroll: {1}, {2}\r\n{3}", (sender as ColorSlider).Name, e.Type, e.NewValue, edEventLog.Text);
            } 
        }

        private void SlidersValueChanged(object sender, EventArgs e)
        {
            if (cbEventLog.Checked)
            {
                edEventLog.Text = String.Format("{0}, ValueChange: {1}\r\n{2}", (sender as ColorSlider).Name, (sender as ColorSlider).Value, edEventLog.Text);
            } 
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {            
        }
    }
}