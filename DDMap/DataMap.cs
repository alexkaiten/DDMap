using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DDMap
{
    [Serializable]
    public class DataMap
    {
        public Dictionary<String, MapSquare> Squares { get; set; }
        public String ImageName { get; set; }
        public List<Character> Characters { get; set; }
        public String MapName { get; set; }
        public int CellSize { get; set; }

        public DataMap()
        {
            Squares = new Dictionary<String, MapSquare>();
            ImageName = String.Empty;
            Characters = new List<Character>();
            MapName = string.Empty;
            CellSize = -1;
        }

        public DataMap(string name, int cellSize)
        {
            Squares = new Dictionary<String, MapSquare>();
            ImageName = name + ".bmp";
            Characters = new List<Character>();
            MapName = name;
            CellSize = cellSize;
        }
    }
}
