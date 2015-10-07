using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexCCGUI
{
    public partial class frmMainWindow : Form
    {
        private string HCCLocation { get; set; }
        private string DCCLocation { get; set; }
        private string TextEditorLocation { get; set; }

        private string GameLocation { get; set; }
        private string RunArguments { get; set; }
        private string ProjectLocation { get; set; }
        private string OutputLocation { get; set; }
        private string CompilationOutput { get; set; }

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
                OutputV7 = chbV7.Checked = false;
            }

            OutputV6 = chbV6.Checked;
        }

        private void chbV7_CheckedChanged(object sender, EventArgs e)
        {
            if (chbV7.Checked && chbV6.Checked)
            {
                OutputV6 = chbV6.Checked = false;
            }

            OutputV7 = chbV7.Checked;
        }

        private void chbMaintain_CheckedChanged(object sender, EventArgs e)
        {
            MaintainOutput = chbMaintain.Checked;
        }

        private void frmMainWindow_Load(object sender, EventArgs e)
        {
            //load values from config file
            //string values--
            HCCLocation = Properties.Settings.Default.HCCLocation;
            DCCLocation = Properties.Settings.Default.DCCLocation;
            TextEditorLocation = Properties.Settings.Default.TextEditorLocation;

            txbGameLoc.Text = GameLocation = Properties.Settings.Default.GameLocation;
            txbProjectSrc.Text = ProjectLocation = Properties.Settings.Default.ProjectLocation;
            txbOutputLoc.Text = OutputLocation = Properties.Settings.Default.OutputLocation;
            txbRunArguments.Text = RunArguments = Properties.Settings.Default.RunArguments;
            //boolean values--
            chbOI.Checked = OptimizeImmediates = Properties.Settings.Default.OptimizeImmediates;
            chbON.Checked = OptimizeNametables = Properties.Settings.Default.OptimizeNametables;
            chbOldHCC.Checked = OldHCC = Properties.Settings.Default.OldHCC;
            chbFileInfo.Checked = OutputFileinfo = Properties.Settings.Default.OptimizeImmediates;
            chbV6.Checked = OutputV6 = Properties.Settings.Default.OutputV6;
            chbV7.Checked = OutputV7 = Properties.Settings.Default.OutputV7;

            chbMaintain.Checked = MaintainOutput = Properties.Settings.Default.MaintainOutput;
            chbRun.Checked = RunAfterCompile = Properties.Settings.Default.RunAfterCompile;
        }

        private void frmMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save values to config file
            Properties.Settings.Default.GameLocation = GameLocation;
            Properties.Settings.Default.ProjectLocation = ProjectLocation;
            Properties.Settings.Default.OutputLocation = OutputLocation;
            Properties.Settings.Default.RunArguments = RunArguments;

            //boolean values--
            Properties.Settings.Default.OptimizeImmediates = OptimizeImmediates;
            Properties.Settings.Default.OptimizeNametables = OptimizeNametables;
            Properties.Settings.Default.OldHCC = OldHCC;
            Properties.Settings.Default.FileInfo = OutputFileinfo;
            Properties.Settings.Default.OutputV6 = OutputV6;
            Properties.Settings.Default.OutputV7 = OutputV7;

            Properties.Settings.Default.MaintainOutput = MaintainOutput;
            Properties.Settings.Default.RunAfterCompile = RunAfterCompile;            

            Properties.Settings.Default.Save();
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
            txbCompileOutput.Text = "";

            //Compile code
            Process compiler = new Process();
            compiler.StartInfo.FileName = HCCLocation;
            compiler.StartInfo.UseShellExecute = false;
            compiler.StartInfo.CreateNoWindow = true;
            compiler.StartInfo.RedirectStandardOutput = true;

            //sets compiler arguments
            compiler.StartInfo.Arguments = "-src " + Path.GetDirectoryName(ProjectLocation) + " -name " + Path.GetFileName(ProjectLocation);
            if (OptimizeImmediates)
                compiler.StartInfo.Arguments += " -oi";
            if (OptimizeNametables)
                compiler.StartInfo.Arguments += " -on";
            if (OldHCC)
                compiler.StartInfo.Arguments += " -old";
            if (OutputFileinfo)
                compiler.StartInfo.Arguments += " -fileinfo";
            if (OutputV6)
                compiler.StartInfo.Arguments += " -v6";
            if (OutputV7)
                compiler.StartInfo.Arguments += " -v7";

            //starts compilation process
            Console.WriteLine(compiler.StartInfo.Arguments);
            compiler.Start();

            try
            {
                txbCompileOutput.Text = compiler.StandardOutput.ReadToEnd();
            }
            catch (System.InvalidOperationException exc)
            {
                Console.WriteLine(exc.ToString());
            }
            compiler.WaitForExit();
            Utils.scrollToEnd(txbCompileOutput);

            //Copy output to output folder and open Hexen II if compilation was successful
            if(compiler.ExitCode == 0 && RunAfterCompile)
            {
                string compiledFile, outputFile;
                compiledFile = Path.GetDirectoryName(ProjectLocation) + "\\progs.dat";
                outputFile = OutputLocation + "\\progs.dat";
                try
                {
                    File.Copy(compiledFile, outputFile, true);
                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc.ToString());
                }

                if(File.Exists(outputFile))
                {
                    System.Threading.Thread.Sleep(1000);

                    //Run HEXEN II
                    Process hexen = new Process();
                    hexen.StartInfo.FileName = GameLocation;
                    hexen.StartInfo.WorkingDirectory = Path.GetDirectoryName(GameLocation);
                    hexen.StartInfo.Arguments = "-game " + Path.GetFileName(OutputLocation) + " ";
                    hexen.StartInfo.Arguments += RunArguments;
                    Console.WriteLine(hexen.StartInfo.Arguments);
                    hexen.Start();
                }
            }
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
                if (new DirectoryInfo(outputfold.SelectedPath).Exists)
                    OutputLocation = txbOutputLoc.Text = outputfold.SelectedPath;
            }
            catch (Exception excep)
            {
                Console.Out.WriteLine(excep.ToString());
                MessageBox.Show(outputfold.SelectedPath + " is an invalid Output Path", "You are stupid", MessageBoxButtons.OK);
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
            dbgText += "Compiler Settings===============================\r\n";
            dbgText += "    HCC Location: " + HCCLocation + "\r\n";
            dbgText += "    DCC Location: " + DCCLocation + "\r\n";
            dbgText += "    Text Editor Location: " + TextEditorLocation + "\r\n\r\n";

            dbgText += "Project Settings================================\r\n";
            dbgText += "    Game Location: " + GameLocation + "\r\n";
            dbgText += "    Project Location: " + ProjectLocation + "\r\n";
            dbgText += "    Output Location: " + OutputLocation + "\r\n";
            dbgText += "    Optional arguments: " + txbRunArguments.Text + "\r\n\r\n";

            dbgText += "Compilation Settings============================\r\n";
            dbgText += "    Optimize Immediates: " + OptimizeImmediates + "\r\n";
            dbgText += "    Optimize Nametables: " + OptimizeNametables + "\r\n";
            dbgText += "    OldHCC: " + OldHCC + "\r\n";
            dbgText += "    Output FileInfo: " + OutputFileinfo + "\r\n";
            dbgText += "    Output V6: " + OutputV6 + "\r\n";
            dbgText += "    Output V7: " + OutputV7 + "\r\n\r\n";

            dbgText += "Run Settings====================================\r\n";
            dbgText += "    Run after compilation: " + RunAfterCompile + "\r\n";


            txbCompileOutput.Text = dbgText;
            Utils.scrollToEnd(txbCompileOutput);
            txbCompileOutput.ScrollToCaret();
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

        private void txbRunArguments_Leave(object sender, EventArgs e)
        {
            RunArguments = txbRunArguments.Text;
        }

        private void frmMainWindow_Activated(object sender, EventArgs e)
        {
            HCCLocation = Properties.Settings.Default.HCCLocation;
            DCCLocation = Properties.Settings.Default.DCCLocation;
            TextEditorLocation = Properties.Settings.Default.TextEditorLocation;
        }

        private void btnOpenTextEditor_Click(object sender, EventArgs e)
        {
            Process textEditor = new Process();
            textEditor.StartInfo.FileName = TextEditorLocation;
            textEditor.StartInfo.Arguments = Path.GetDirectoryName(ProjectLocation);
            textEditor.StartInfo.UseShellExecute = false;

            textEditor.Start();

            //textEditor.WaitForExit();
        }

        private void txbOutputLoc_Leave(object sender, EventArgs e)
        {
            if (Utils.checkValidDirectoryPath(txbOutputLoc.Text))
            {
                OutputLocation = txbOutputLoc.Text;
            }
            else
            {
                MessageBox.Show(txbOutputLoc.Text + " is an invalid location!", "Invalid Path", MessageBoxButtons.OK);
                txbOutputLoc.Text = OutputLocation;
            }
        }

        private void txbProjectSrc_Leave(object sender, EventArgs e)
        {
            if (Utils.checkValidFilePath(txbProjectSrc.Text))
            {
                ProjectLocation = txbProjectSrc.Text;
            }
            else
            {
                MessageBox.Show(txbOutputLoc.Text + " is an invalid src file!", "Invalid SRC", MessageBoxButtons.OK);
                txbProjectSrc.Text = ProjectLocation;
            }
        }

        private void txbGameLoc_Leave(object sender, EventArgs e)
        {
            if (Utils.checkValidFilePath(txbGameLoc.Text))
            {
                GameLocation = txbGameLoc.Text;
            }
            else
            {
                MessageBox.Show(txbGameLoc.Text + " is an invalid Hexen II engine!", "Invalid HII Path", MessageBoxButtons.OK);
                txbGameLoc.Text = GameLocation;
            }
        }
    }
}
