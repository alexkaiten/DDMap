using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDMap
{
    public static class Logger
    {
        public static void Write(String s)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(Path.GetDirectoryName(Application.ExecutablePath) + @"\Logs\logs.txt", true))
            {

                file.WriteLine(s);


            }
        }
    }
}
