using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexCCGUI
{
    class Utils
    {
        public static void scrollToEnd(TextBoxBase txb)
        {
            txb.Focus();
            txb.Select(txb.TextLength, 0);
        }

        public static bool checkValidDirectoryPath(string directoryPath)
        {
            if (new DirectoryInfo(directoryPath).Exists)
            {
                return true;
            }
            return false;
        }
        public static bool checkValidFilePath(string filePath)
        {
            if (new FileInfo(filePath).Exists)
            {
                return true;
            }
            return false;
        }

        public static void foo()
        {

        }
    }
}
