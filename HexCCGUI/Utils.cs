using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexCCGUI
{
    class Utils
    {
        public static void scrollToEnd(TextBox txb)
        {
            txb.Focus();
            txb.Select(txb.TextLength, 0);
        }
    }
}
