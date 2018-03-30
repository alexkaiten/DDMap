using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDMap
{
    [Serializable]
    public class Common
    {
        [Serializable]
        public enum DDSize { Minuscola=1, Piccola, Media, Grande, Enorme, Colossale};
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
    }
}
