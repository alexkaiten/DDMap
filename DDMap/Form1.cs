using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDMap
{
    public partial class Form1 : Form
    {

        public DataMap dataMap = new DataMap();
        public Bitmap bmap;

        public Form1()
        {
            InitializeComponent();
            SetDirectories();
            archetypeControl.dataMap = dataMap;
            mapControl.dataMap = dataMap;
            mapControl.Visible = true;
            archetypeControl.Visible = false;
            mapCreationControl.Visible = false;
        }

        private void SetDirectories()
        {
            try
            {
                // If the directory doesn't exist, create it.
                if (!Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\Save"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\Save");
                }
                if (!Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\Save\Images"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\Save\Images");
                }
                if (!Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\Archetypes"))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + @"\Archetypes");
                }
            }
            catch (Exception)
            {
                // Fail silently
            }
        }

        private void menuToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatusMapMenu(e.ClickedItem);
        }

        private void UpdateStatusMapMenu(ToolStripItem item)
        {
            if (item != null)
            {
                if (item.Text.Equals("Manage Characters"))
                {
                    mapControl.Visible = false;
                    archetypeControl.Visible = true;
                    mapCreationControl.Visible = false;
                }
                else if (item.Text.Equals("Manage Map"))
                {
                    mapControl.Visible = true;
                    archetypeControl.Visible = false;
                    mapCreationControl.Visible = false;
                }

            }
        }

        private void loadSaveToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.UpdateStatusFileMenu(e.ClickedItem);
        }

        private void UpdateStatusFileMenu(ToolStripItem item)
        {
            if (item != null)
            {
                if (item.Text.Equals("New"))
                {
                    mapControl.Visible = false;
                    archetypeControl.Visible = false;
                    mapCreationControl.Visible = true;
                }
                else if (item.Text.Equals("Load"))
                {
                    LoadMap();
                    
                }
                else if (item.Text.Equals("Save"))
                {
                    SaveMap();
                }

            }
        }

        private void UpdateChildControls(Bitmap mapBitmap)
        {
            archetypeControl.dataMap = dataMap;
            mapControl.dataMap = dataMap;
            if (mapBitmap != null)
            {
                mapControl.bmap = mapBitmap;
            }
            archetypeControl.UpdateCharacterList();
            mapControl.UpdateMap();
        }

        public void UpdateCharacterList()
        {
            archetypeControl.UpdateCharacterList();
            mapControl.UpdateCharacterList();
        }

        private void LoadMap()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath) + @"\Save\";
            openFileDialog1.Filter = "sav files (*.sav)|*.sav|All files (*.*)|*.*";
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
                            if (Path.GetExtension(openFileDialog1.FileName) == ".sav")
                            {
                                BinaryFormatter formatter = new BinaryFormatter();
                                dataMap = (DataMap)formatter.Deserialize(myStream);
                                Bitmap bmap = null;
                                if (openFileDialog1.FileName != String.Empty)
                                { 
                                    string pathLocation = Path.GetDirectoryName(openFileDialog1.FileName);
                                    bmap = new Bitmap(pathLocation + "\\Images\\" + dataMap.ImageName);
                                }
                                UpdateChildControls(bmap);
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

        private void SaveMap()
        {
            if (dataMap.MapName != null && dataMap.MapName != string.Empty)
            {
                string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\Save\Images\" + dataMap.MapName + ".bmp";
                Bitmap bmap = mapControl.bmap;
                if (!System.IO.File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + @"\Save\Images\" + dataMap.MapName + ".bmp"))
                {
                    ((Image)bmap).Save(path, ImageFormat.Bmp);
                }
                FileStream stream = File.Create(Path.GetDirectoryName(Application.ExecutablePath) + @"\Save\" + dataMap.MapName + ".sav");
                try
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, dataMap);
                    stream.Close();
                }
                catch (Exception ex)
                {
                    string exception = ex.ToString();
                    stream.Close();
                }
            }
        }

        public void NewMap(string name, Bitmap image, int cellSize)
        {
            dataMap = new DataMap(name, cellSize);
            UpdateChildControls(image);
            mapControl.Visible = true;
            archetypeControl.Visible = false;
            mapCreationControl.Visible = false;
        }

    }
}
