namespace HexCCGUI
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.btnCompile = new System.Windows.Forms.Button();
            this.pnlOutput = new System.Windows.Forms.Panel();
            this.txbCompileOutput = new System.Windows.Forms.RichTextBox();
            this.btnOpenTextEditor = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decompileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compilerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHCCGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbV7 = new System.Windows.Forms.CheckBox();
            this.chbV6 = new System.Windows.Forms.CheckBox();
            this.chbFileInfo = new System.Windows.Forms.CheckBox();
            this.chbOldHCC = new System.Windows.Forms.CheckBox();
            this.chbON = new System.Windows.Forms.CheckBox();
            this.chbOI = new System.Windows.Forms.CheckBox();
            this.chbRun = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGameLoc = new System.Windows.Forms.Button();
            this.txbRunArguments = new System.Windows.Forms.TextBox();
            this.lblRunArguments = new System.Windows.Forms.Label();
            this.txbGameLoc = new System.Windows.Forms.TextBox();
            this.lblGameLoc = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chbMaintain = new System.Windows.Forms.CheckBox();
            this.btnDecompile = new System.Windows.Forms.Button();
            this.btnOutputLoc = new System.Windows.Forms.Button();
            this.btnProjectSrc = new System.Windows.Forms.Button();
            this.txbProjectSrc = new System.Windows.Forms.TextBox();
            this.txbOutputLoc = new System.Windows.Forms.TextBox();
            this.lblProjectSrc = new System.Windows.Forms.Label();
            this.lblOutputLoc = new System.Windows.Forms.Label();
            this.picHexLogo = new System.Windows.Forms.PictureBox();
            this.pnlOutput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHexLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompile
            // 
            this.btnCompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.btnCompile.Location = new System.Drawing.Point(166, 221);
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Size = new System.Drawing.Size(106, 51);
            this.btnCompile.TabIndex = 7;
            this.btnCompile.Text = "Compile";
            this.btnCompile.UseVisualStyleBackColor = true;
            this.btnCompile.Click += new System.EventHandler(this.btnCompile_Click);
            // 
            // pnlOutput
            // 
            this.pnlOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOutput.Controls.Add(this.txbCompileOutput);
            this.pnlOutput.Controls.Add(this.btnOpenTextEditor);
            this.pnlOutput.Controls.Add(this.lblOutput);
            this.pnlOutput.Controls.Add(this.btnClearOutput);
            this.pnlOutput.Location = new System.Drawing.Point(14, 374);
            this.pnlOutput.Name = "pnlOutput";
            this.pnlOutput.Size = new System.Drawing.Size(562, 238);
            this.pnlOutput.TabIndex = 12;
            // 
            // txbCompileOutput
            // 
            this.txbCompileOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txbCompileOutput.Location = new System.Drawing.Point(3, 29);
            this.txbCompileOutput.Name = "txbCompileOutput";
            this.txbCompileOutput.ReadOnly = true;
            this.txbCompileOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txbCompileOutput.Size = new System.Drawing.Size(554, 175);
            this.txbCompileOutput.TabIndex = 28;
            this.txbCompileOutput.Text = "";
            // 
            // btnOpenTextEditor
            // 
            this.btnOpenTextEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.btnOpenTextEditor.Location = new System.Drawing.Point(449, 210);
            this.btnOpenTextEditor.Name = "btnOpenTextEditor";
            this.btnOpenTextEditor.Size = new System.Drawing.Size(108, 23);
            this.btnOpenTextEditor.TabIndex = 27;
            this.btnOpenTextEditor.Text = "Open Text Editor";
            this.btnOpenTextEditor.UseVisualStyleBackColor = true;
            this.btnOpenTextEditor.Click += new System.EventHandler(this.btnOpenTextEditor_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(14, 12);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(96, 13);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "Compilation Output";
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(3, 210);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(102, 23);
            this.btnClearOutput.TabIndex = 10;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem,
            this.decompileToolStripMenuItem,
            this.toolStripSeparator1});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Image = global::HexCCGUI.Properties.Resources.Compile_191;
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.compileToolStripMenuItem.Text = "Compile";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // decompileToolStripMenuItem
            // 
            this.decompileToolStripMenuItem.Image = global::HexCCGUI.Properties.Resources.WireframeView;
            this.decompileToolStripMenuItem.Name = "decompileToolStripMenuItem";
            this.decompileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F8)));
            this.decompileToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.decompileToolStripMenuItem.Text = "Decompile";
            this.decompileToolStripMenuItem.Click += new System.EventHandler(this.decompileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(174, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compilerSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // compilerSettingsToolStripMenuItem
            // 
            this.compilerSettingsToolStripMenuItem.Image = global::HexCCGUI.Properties.Resources.AdministerTestControllers_8573;
            this.compilerSettingsToolStripMenuItem.Name = "compilerSettingsToolStripMenuItem";
            this.compilerSettingsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.compilerSettingsToolStripMenuItem.Text = "HCC Settings";
            this.compilerSettingsToolStripMenuItem.Click += new System.EventHandler(this.compilerSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutHCCGUIToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutHCCGUIToolStripMenuItem
            // 
            this.aboutHCCGUIToolStripMenuItem.Image = global::HexCCGUI.Properties.Resources.InfoTooltip_16x;
            this.aboutHCCGUIToolStripMenuItem.Name = "aboutHCCGUIToolStripMenuItem";
            this.aboutHCCGUIToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutHCCGUIToolStripMenuItem.Text = "About";
            this.aboutHCCGUIToolStripMenuItem.Click += new System.EventHandler(this.aboutHCCGUIToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbV7);
            this.groupBox1.Controls.Add(this.chbV6);
            this.groupBox1.Controls.Add(this.chbFileInfo);
            this.groupBox1.Controls.Add(this.chbOldHCC);
            this.groupBox1.Controls.Add(this.chbON);
            this.groupBox1.Controls.Add(this.chbOI);
            this.groupBox1.Location = new System.Drawing.Point(15, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 181);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compile Options";
            // 
            // chbV7
            // 
            this.chbV7.AutoSize = true;
            this.chbV7.Location = new System.Drawing.Point(17, 137);
            this.chbV7.Name = "chbV7";
            this.chbV7.Size = new System.Drawing.Size(88, 17);
            this.chbV7.TabIndex = 23;
            this.chbV7.Text = "Output as V7";
            this.chbV7.UseVisualStyleBackColor = true;
            this.chbV7.CheckedChanged += new System.EventHandler(this.chbV7_CheckedChanged);
            // 
            // chbV6
            // 
            this.chbV6.AutoSize = true;
            this.chbV6.Location = new System.Drawing.Point(17, 114);
            this.chbV6.Name = "chbV6";
            this.chbV6.Size = new System.Drawing.Size(88, 17);
            this.chbV6.TabIndex = 22;
            this.chbV6.Text = "Output as V6";
            this.chbV6.UseVisualStyleBackColor = true;
            this.chbV6.CheckedChanged += new System.EventHandler(this.chbV6_CheckedChanged);
            // 
            // chbFileInfo
            // 
            this.chbFileInfo.AutoSize = true;
            this.chbFileInfo.Location = new System.Drawing.Point(17, 91);
            this.chbFileInfo.Name = "chbFileInfo";
            this.chbFileInfo.Size = new System.Drawing.Size(60, 17);
            this.chbFileInfo.TabIndex = 21;
            this.chbFileInfo.Text = "FileInfo";
            this.chbFileInfo.UseVisualStyleBackColor = true;
            this.chbFileInfo.CheckedChanged += new System.EventHandler(this.chbFileInfo_CheckedChanged);
            // 
            // chbOldHCC
            // 
            this.chbOldHCC.AutoSize = true;
            this.chbOldHCC.Location = new System.Drawing.Point(17, 68);
            this.chbOldHCC.Name = "chbOldHCC";
            this.chbOldHCC.Size = new System.Drawing.Size(67, 17);
            this.chbOldHCC.TabIndex = 20;
            this.chbOldHCC.Text = "Old HCC";
            this.chbOldHCC.UseVisualStyleBackColor = true;
            this.chbOldHCC.CheckedChanged += new System.EventHandler(this.chbOldHCC_CheckedChanged);
            // 
            // chbON
            // 
            this.chbON.AutoSize = true;
            this.chbON.Location = new System.Drawing.Point(17, 45);
            this.chbON.Name = "chbON";
            this.chbON.Size = new System.Drawing.Size(125, 17);
            this.chbON.TabIndex = 19;
            this.chbON.Text = "Optimize Nametables";
            this.chbON.UseVisualStyleBackColor = true;
            this.chbON.CheckedChanged += new System.EventHandler(this.chbON_CheckedChanged);
            // 
            // chbOI
            // 
            this.chbOI.AutoSize = true;
            this.chbOI.Location = new System.Drawing.Point(17, 22);
            this.chbOI.Name = "chbOI";
            this.chbOI.Size = new System.Drawing.Size(122, 17);
            this.chbOI.TabIndex = 18;
            this.chbOI.Text = "Optimize Immediates";
            this.chbOI.UseVisualStyleBackColor = true;
            this.chbOI.CheckedChanged += new System.EventHandler(this.chbOI_CheckedChanged);
            // 
            // chbRun
            // 
            this.chbRun.AutoSize = true;
            this.chbRun.Location = new System.Drawing.Point(17, 148);
            this.chbRun.Name = "chbRun";
            this.chbRun.Size = new System.Drawing.Size(89, 17);
            this.chbRun.TabIndex = 15;
            this.chbRun.Text = "Run Hexen II";
            this.chbRun.UseVisualStyleBackColor = true;
            this.chbRun.CheckedChanged += new System.EventHandler(this.chbRun_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGameLoc);
            this.groupBox3.Controls.Add(this.txbRunArguments);
            this.groupBox3.Controls.Add(this.lblRunArguments);
            this.groupBox3.Controls.Add(this.txbGameLoc);
            this.groupBox3.Controls.Add(this.lblGameLoc);
            this.groupBox3.Location = new System.Drawing.Point(15, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 142);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Configuration";
            // 
            // btnGameLoc
            // 
            this.btnGameLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGameLoc.Image = global::HexCCGUI.Properties.Resources.folder_Open_16xLG;
            this.btnGameLoc.Location = new System.Drawing.Point(228, 41);
            this.btnGameLoc.Name = "btnGameLoc";
            this.btnGameLoc.Size = new System.Drawing.Size(33, 23);
            this.btnGameLoc.TabIndex = 15;
            this.btnGameLoc.UseVisualStyleBackColor = true;
            this.btnGameLoc.Click += new System.EventHandler(this.btnGameLoc_Click);
            // 
            // txbRunArguments
            // 
            this.txbRunArguments.Location = new System.Drawing.Point(13, 90);
            this.txbRunArguments.Name = "txbRunArguments";
            this.txbRunArguments.Size = new System.Drawing.Size(248, 20);
            this.txbRunArguments.TabIndex = 14;
            this.txbRunArguments.Leave += new System.EventHandler(this.txbRunArguments_Leave);
            // 
            // lblRunArguments
            // 
            this.lblRunArguments.AutoSize = true;
            this.lblRunArguments.Location = new System.Drawing.Point(10, 74);
            this.lblRunArguments.Name = "lblRunArguments";
            this.lblRunArguments.Size = new System.Drawing.Size(122, 13);
            this.lblRunArguments.TabIndex = 13;
            this.lblRunArguments.Text = "Optional Run Arguments";
            // 
            // txbGameLoc
            // 
            this.txbGameLoc.Location = new System.Drawing.Point(13, 44);
            this.txbGameLoc.Name = "txbGameLoc";
            this.txbGameLoc.Size = new System.Drawing.Size(209, 20);
            this.txbGameLoc.TabIndex = 12;
            // 
            // lblGameLoc
            // 
            this.lblGameLoc.AutoSize = true;
            this.lblGameLoc.Location = new System.Drawing.Point(10, 25);
            this.lblGameLoc.Name = "lblGameLoc";
            this.lblGameLoc.Size = new System.Drawing.Size(79, 13);
            this.lblGameLoc.TabIndex = 11;
            this.lblGameLoc.Text = "Game Location";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chbRun);
            this.groupBox4.Controls.Add(this.chbMaintain);
            this.groupBox4.Controls.Add(this.btnDecompile);
            this.groupBox4.Controls.Add(this.btnOutputLoc);
            this.groupBox4.Controls.Add(this.btnProjectSrc);
            this.groupBox4.Controls.Add(this.txbProjectSrc);
            this.groupBox4.Controls.Add(this.txbOutputLoc);
            this.groupBox4.Controls.Add(this.lblProjectSrc);
            this.groupBox4.Controls.Add(this.lblOutputLoc);
            this.groupBox4.Controls.Add(this.btnCompile);
            this.groupBox4.Location = new System.Drawing.Point(298, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(278, 329);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Project Settings";
            // 
            // chbMaintain
            // 
            this.chbMaintain.AutoSize = true;
            this.chbMaintain.Enabled = false;
            this.chbMaintain.Location = new System.Drawing.Point(17, 123);
            this.chbMaintain.Name = "chbMaintain";
            this.chbMaintain.Size = new System.Drawing.Size(187, 17);
            this.chbMaintain.TabIndex = 25;
            this.chbMaintain.Text = "Maintain Output Files in Src Folder";
            this.chbMaintain.UseVisualStyleBackColor = true;
            this.chbMaintain.CheckedChanged += new System.EventHandler(this.chbMaintain_CheckedChanged);
            // 
            // btnDecompile
            // 
            this.btnDecompile.Enabled = false;
            this.btnDecompile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.btnDecompile.Location = new System.Drawing.Point(182, 284);
            this.btnDecompile.Name = "btnDecompile";
            this.btnDecompile.Size = new System.Drawing.Size(83, 39);
            this.btnDecompile.TabIndex = 27;
            this.btnDecompile.Text = "Decompile";
            this.btnDecompile.UseVisualStyleBackColor = true;
            this.btnDecompile.Click += new System.EventHandler(this.btnDecompile_Click);
            // 
            // btnOutputLoc
            // 
            this.btnOutputLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOutputLoc.Image = global::HexCCGUI.Properties.Resources.folder_Open_16xLG;
            this.btnOutputLoc.Location = new System.Drawing.Point(232, 94);
            this.btnOutputLoc.Name = "btnOutputLoc";
            this.btnOutputLoc.Size = new System.Drawing.Size(33, 23);
            this.btnOutputLoc.TabIndex = 19;
            this.btnOutputLoc.UseVisualStyleBackColor = true;
            this.btnOutputLoc.Click += new System.EventHandler(this.btnOutputLoc_Click);
            // 
            // btnProjectSrc
            // 
            this.btnProjectSrc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProjectSrc.Image = global::HexCCGUI.Properties.Resources.folder_Open_16xLG;
            this.btnProjectSrc.Location = new System.Drawing.Point(232, 47);
            this.btnProjectSrc.Name = "btnProjectSrc";
            this.btnProjectSrc.Size = new System.Drawing.Size(33, 23);
            this.btnProjectSrc.TabIndex = 20;
            this.btnProjectSrc.UseVisualStyleBackColor = true;
            this.btnProjectSrc.Click += new System.EventHandler(this.btnProjectSrc_Click);
            // 
            // txbProjectSrc
            // 
            this.txbProjectSrc.Location = new System.Drawing.Point(17, 49);
            this.txbProjectSrc.Name = "txbProjectSrc";
            this.txbProjectSrc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbProjectSrc.Size = new System.Drawing.Size(209, 20);
            this.txbProjectSrc.TabIndex = 22;
            // 
            // txbOutputLoc
            // 
            this.txbOutputLoc.HideSelection = false;
            this.txbOutputLoc.Location = new System.Drawing.Point(17, 97);
            this.txbOutputLoc.Name = "txbOutputLoc";
            this.txbOutputLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txbOutputLoc.Size = new System.Drawing.Size(209, 20);
            this.txbOutputLoc.TabIndex = 24;
            // 
            // lblProjectSrc
            // 
            this.lblProjectSrc.AutoSize = true;
            this.lblProjectSrc.Location = new System.Drawing.Point(14, 32);
            this.lblProjectSrc.Name = "lblProjectSrc";
            this.lblProjectSrc.Size = new System.Drawing.Size(59, 13);
            this.lblProjectSrc.TabIndex = 21;
            this.lblProjectSrc.Text = "Project Src";
            // 
            // lblOutputLoc
            // 
            this.lblOutputLoc.AutoSize = true;
            this.lblOutputLoc.Location = new System.Drawing.Point(14, 81);
            this.lblOutputLoc.Name = "lblOutputLoc";
            this.lblOutputLoc.Size = new System.Drawing.Size(83, 13);
            this.lblOutputLoc.TabIndex = 23;
            this.lblOutputLoc.Text = "Output Location";
            // 
            // picHexLogo
            // 
            this.picHexLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picHexLogo.Image = ((System.Drawing.Image)(resources.GetObject("picHexLogo.Image")));
            this.picHexLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picHexLogo.InitialImage")));
            this.picHexLogo.Location = new System.Drawing.Point(246, 8);
            this.picHexLogo.Name = "picHexLogo";
            this.picHexLogo.Size = new System.Drawing.Size(95, 60);
            this.picHexLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHexLogo.TabIndex = 26;
            this.picHexLogo.TabStop = false;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(588, 624);
            this.Controls.Add(this.picHexLogo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlOutput);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMainWindow";
            this.Text = "HCC Compiling GUI";
            this.Activated += new System.EventHandler(this.frmMainWindow_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainWindow_FormClosing);
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainWindow_KeyDown);
            this.pnlOutput.ResumeLayout(false);
            this.pnlOutput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHexLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCompile;
        private System.Windows.Forms.Panel pnlOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compilerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHCCGUIToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbV7;
        private System.Windows.Forms.CheckBox chbV6;
        private System.Windows.Forms.CheckBox chbFileInfo;
        private System.Windows.Forms.CheckBox chbOldHCC;
        private System.Windows.Forms.CheckBox chbON;
        private System.Windows.Forms.CheckBox chbOI;
        private System.Windows.Forms.CheckBox chbRun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGameLoc;
        private System.Windows.Forms.TextBox txbRunArguments;
        private System.Windows.Forms.Label lblRunArguments;
        private System.Windows.Forms.TextBox txbGameLoc;
        private System.Windows.Forms.Label lblGameLoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOutputLoc;
        private System.Windows.Forms.Button btnProjectSrc;
        private System.Windows.Forms.TextBox txbOutputLoc;
        private System.Windows.Forms.Label lblProjectSrc;
        private System.Windows.Forms.Label lblOutputLoc;
        private System.Windows.Forms.PictureBox picHexLogo;
        private System.Windows.Forms.Button btnOpenTextEditor;
        private System.Windows.Forms.Button btnDecompile;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decompileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.RichTextBox txbCompileOutput;
        private System.Windows.Forms.CheckBox chbMaintain;
        private System.Windows.Forms.TextBox txbProjectSrc;
    }
}

