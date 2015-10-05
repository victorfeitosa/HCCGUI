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
    public partial class frmMainWindow : Form
    {
        private string HCClocation { get; set; }
        private string HDbglocation { get; set; }
        private string HCCArguments { get; set; }

        private string GameLocation { get; set; }
        private string ProjectLocation { get; set; }
        private string OutputLocation { get; set; }
        private string CompilationOutput { get; set; }

        private bool PauseAfterCompile { get; set; }
        private bool RunAfterCompile { get; set; }
        private bool OptimizeImmediates { get; set; }
        private bool OptimizeNametables { get; set; }
        private bool OldHCC { get; set; }
        private bool OutputFileinfo { get; set; }
        private bool OutputV6 { get; set; }
        private bool OutputV7 { get; set; }
        private bool MaintainOutput { get; set; }

        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void chbPause_CheckedChanged(object sender, EventArgs e)
        {
            PauseAfterCompile = chbPause.Checked;
        }

        private void chbRun_CheckedChanged(object sender, EventArgs e)
        {
            RunAfterCompile = chbRun.Checked;
        }

        private void chbFileInfo_CheckedChanged(object sender, EventArgs e)
        {
            OutputFileinfo = chbFileInfo.Checked;
        }

        private void chbOI_CheckedChanged(object sender, EventArgs e)
        {
            OptimizeImmediates = chbOI.Checked;
        }

        private void chbON_CheckedChanged(object sender, EventArgs e)
        {
            OptimizeNametables = chbON.Checked;
        }

        private void chbOldHCC_CheckedChanged(object sender, EventArgs e)
        {
            OldHCC = chbOldHCC.Checked;
        }

        private void chbV6_CheckedChanged(object sender, EventArgs e)
        {
            if (chbV6.Checked && chbV7.Checked)
            {
                chbV7.Checked = false;
            }

            OutputV6 = chbV6.Checked;
        }

        private void chbV7_CheckedChanged(object sender, EventArgs e)
        {
            if (chbV7.Checked && chbV6.Checked)
            {
                chbV6.Checked = false;
            }

            OutputV7 = chbV7.Checked;
        }

        private void chbMaintain_CheckedChanged(object sender, EventArgs e)
        {
            MaintainOutput = chbMaintain.Checked;
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            // TODO: Implement this
            //load values from config file
        }

        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TODO: Implement this
            //save values to config file
        }

        private void frmMainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F7)
            {
                //Compile code
                btnCompile_Click(sender, null);
            }
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            //Compile code
            showDbg();
        }

        private void btnDecompile_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            //Decompile code
        }

        private void btnGameLoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog gameloc = new OpenFileDialog();
            gameloc.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";
            gameloc.FilterIndex = 1;
            gameloc.RestoreDirectory = true;

            try
            {
                gameloc.ShowDialog();
                if (gameloc.FileName != "")
                    GameLocation = txbGameLoc.Text = gameloc.FileName;
            }
            catch (Exception excep)
            {
                Console.Out.WriteLine(excep.ToString());
            }
            Utils.scrollToEnd(txbGameLoc);
        }

        private void btnProjectSrc_Click(object sender, EventArgs e)
        {
            OpenFileDialog projectSrc = new OpenFileDialog();
            projectSrc.Filter = "Src files (*.src)|*.src";
            projectSrc.FilterIndex = 1;
            projectSrc.RestoreDirectory = true;

            try
            {
                projectSrc.ShowDialog();
                if (projectSrc.FileName != "")
                    ProjectLocation = txbProjectSrc.Text = projectSrc.FileName;
            }
            catch (Exception excep)
            {
                Console.Out.WriteLine(excep.ToString());
            }
            Utils.scrollToEnd(txbProjectSrc);
        }

        private void btnOutputLoc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputfold = new FolderBrowserDialog();

            try
            {
                outputfold.ShowDialog();
                if (outputfold.SelectedPath != "")
                    OutputLocation = txbOutputLoc.Text = outputfold.SelectedPath;
            }
            catch (Exception excep)
            {
                Console.Out.WriteLine(excep.ToString());
            }

            Utils.scrollToEnd(txbOutputLoc);
        }

        private void aboutHCCGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout aboutBox = new frmAbout();
            aboutBox.Show();
        }

        private void showDbg()
        {
            string dbgText = "";
            dbgText += "Game Location: " + GameLocation + "\r\n";
            dbgText += "Project Location: " + ProjectLocation + "\r\n";
            dbgText += "Output Location: " + OutputLocation + "\r\n";
            dbgText += "Optional arguments: " + txbRunArguments.Text + "\r\n";

            dbgText += "Optimize Immediates: " + OptimizeImmediates + "\r\n";
            dbgText += "Optimize Nametables: " + OptimizeNametables + "\r\n";
            dbgText += "OldHCC: " + OldHCC + "\r\n";
            dbgText += "Output FileInfo: " + OutputFileinfo + "\r\n";
            dbgText += "Output V6: " + OutputV6 + "\r\n";
            dbgText += "Output V7: " + OutputV7 + "\r\n";

            dbgText += "Pause after compilation: " + PauseAfterCompile + "\r\n";
            dbgText += "Run after compilation: " + RunAfterCompile + "\r\n";


            txbCompileOutput.Text = dbgText;
            Utils.scrollToEnd(txbCompileOutput);
        }

        private void compilerSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings settingsWindow = new frmSettings();
            settingsWindow.Show();
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txbCompileOutput.Text = "";
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCompile_Click(sender, e);
        }

        private void decompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDecompile_Click(sender, e);
        }
    }
}
