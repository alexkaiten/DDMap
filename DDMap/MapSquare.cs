using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDMap
{
    [Serializable]
    public class MapSquare
    {
        [NonSerialized]
        private PictureBox _picturebox;

        public PictureBox Picturebox
        {
            get { return _picturebox; }
                
            set { _picturebox = value; }

        }

        [NonSerialized]
        private Image _defaultImage;
        public Image DefaultImage
        {
            get { return _defaultImage; }

            set { _defaultImage = value; }
        }

        public List<Character> Characters { get; set; }

        public MapSquare(PictureBox p)
        {
            Picturebox = p;
            DefaultImage = p.Image;
            Characters = new List<Character>();
        }
    }
}
