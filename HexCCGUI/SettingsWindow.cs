using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexCCGUI
{
    public partial class frmSettings : Form
    {
        private string HCCLocation { get; set; }
        private string DCCLocation { get; set; }
        private string TextEditorLocation { get; set; }

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txbHCCLoc.Text = HCCLocation = Properties.Settings.Default.HCCLocation;
            txbDCCLoc.Text = DCCLocation = Properties.Settings.Default.DCCLocation;
            txbTextEditorLoc.Text = TextEditorLocation = Properties.Settings.Default.TextEditorLocation;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //validate paths
            if (Utils.checkValidFilePath(txbHCCLoc.Text))
            {
                DCCLocation = txbHCCLoc.Text;
            }
            else
            {
                MessageBox.Show(txbHCCLoc.Text + " is an invalid HCC executable!", "Invalid HCC", MessageBoxButtons.OK);
                txbHCCLoc.Text = DCCLocation;

                return;
            }

            if (txbDCCLoc.Text == "" || Utils.checkValidFilePath(txbDCCLoc.Text))
            {
                DCCLocation = txbDCCLoc.Text;
            }
            else
            {
                MessageBox.Show(txbDCCLoc.Text + " is an invalid DCC executable!", "Invalid DCC", MessageBoxButtons.OK);
                txbDCCLoc.Text = DCCLocation;

                return;
            }

            if (txbTextEditorLoc.Text == "" || Utils.checkValidFilePath(txbTextEditorLoc.Text))
            {
                TextEditorLocation = txbTextEditorLoc.Text;
            }
            else
            {
                MessageBox.Show(txbTextEditorLoc.Text + " is an invalid executable!", "Invalid Executable", MessageBoxButtons.OK);
                txbTextEditorLoc.Text = TextEditorLocation;

                return;
            }

            //save settings
            Properties.Settings.Default.HCCLocation = HCCLocation;
            Properties.Settings.Default.DCCLocation = DCCLocation;
            Properties.Settings.Default.TextEditorLocation = TextEditorLocation;

            Properties.Settings.Default.Save();

            //closes window
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //closes window
            this.Close();
        }

        private void btnHCCLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog hccloc = new OpenFileDialog();
            hccloc.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            hccloc.FilterIndex = 1;
            hccloc.RestoreDirectory = true;

            try
            {
                hccloc.ShowDialog();
                if (hccloc.FileName != "")
                    HCCLocation = txbHCCLoc.Text = hccloc.FileName;
            }
            catch (Exception excep)
            {
                Console.Out.WriteLine(excep.ToString());
            }

            Utils.scrollToEnd(txbHCCLoc);
        }

        private void btnDccLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dccloc = new OpenFileDialog();
            dccloc.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            dccloc.FilterIndex = 1;
            dccloc.RestoreDirectory = true;

            try
            {
                dccloc.ShowDialog();
                if (dccloc.FileName != "")
                    DCCLocation = txbDCCLoc.Text = dccloc.FileName;
            }
            catch (Exception excep)
            {
                Console.Out.WriteLine(excep.ToString());
            }

            Utils.scrollToEnd(txbDCCLoc);
        }

        private void btnTextEditorLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog txtEditorloc = new OpenFileDialog();
            txtEditorloc.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            txtEditorloc.FilterIndex = 1;
            txtEditorloc.RestoreDirectory = true;

            try
            {
                txtEditorloc.ShowDialog();
                if (txtEditorloc.FileName != "")
                    TextEditorLocation = txbTextEditorLoc.Text = txtEditorloc.FileName;
            }
            catch (Exception excep)
            {
                Console.Out.WriteLine(excep.ToString());
            }

            Utils.scrollToEnd(txbTextEditorLoc);
        }
    }
}
