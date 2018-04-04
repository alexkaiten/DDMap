using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDMap
{
    [Serializable]
    public class Common
    {
        [Serializable]
        public enum DDSize { Piccolissima = 1, Minuta, Minuscola, Piccola, Media, Grande,
            Enorme, Mastodontica, Colossale};
        private static Dictionary<DDSize, Couple<double>> taglie = new Dictionary<DDSize, Couple<double>>()
        {
            { DDSize.Piccolissima, new Couple<double>(0.1, 0.1)},
            { DDSize.Minuta, new Couple<double>(0.2, 0.2)},
            { DDSize.Minuscola, new Couple<double>(0.5, 0.5)},
            { DDSize.Piccola, new Couple<double>(0.8, 0.8)},
            { DDSize.Media, new Couple<double>(1, 1)},
            { DDSize.Grande, new Couple<double>(1.2, 1.2)},
            { DDSize.Enorme, new Couple<double>(2, 2)},
            { DDSize.Mastodontica, new Couple<double>(4, 4)},
            { DDSize.Colossale, new Couple<double>(8, 8)}
        };
        [Serializable]
        public enum Dadi { d2 = 2, d4 = 4, d6 = 6, d8 = 8, d10 = 10, d12 = 12, d20 = 20, d100 = 100 };
        [Serializable]
        public enum Alignment { LegaleBuono = 1, NeutraleBuono, CaoticoBuono, LegaleNeutrale, NeutralePuro, CaoticoNeutrale, LegaleMalvagio, NeutraleMalvagio, CaoticoMalvagio };

        public const string Png = "PNG Portable Network Graphics (*.png)|" + "*.png";
        public const string Jpg = "JPEG File Interchange Format (*.jpg *.jpeg *jfif)|" + "*.jpg;*.jpeg;*.jfif";
        public const string Bmp = "BMP Windows Bitmap (*.bmp)|" + "*.bmp";
        public const string Tif = "TIF Tagged Imaged File Format (*.tif *.tiff)|" + "*.tif;*.tiff";
        public const string Gif = "GIF Graphics Interchange Format (*.gif)|" + "*.gif";
        public const string AllImages = "Image file|" + "*.png; *.jpg; *.jpeg; *.jfif; *.bmp;*.tif; *.tiff; *.gif";
        public const string AllFiles = "All files (*.*)" + "|*.*";

        public static Dictionary<DDSize, Couple<double>> Taglie { get => taglie; set => taglie = value; }
    }
}
