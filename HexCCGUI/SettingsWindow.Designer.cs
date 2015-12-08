namespace HexCCGUI
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTextEditorLoc = new System.Windows.Forms.Button();
            this.txbTextEditorLoc = new System.Windows.Forms.TextBox();
            this.lblTExtEditor = new System.Windows.Forms.Label();
            this.btnDccLoc = new System.Windows.Forms.Button();
            this.txbDCCLoc = new System.Windows.Forms.TextBox();
            this.lblDccLoc = new System.Windows.Forms.Label();
            this.btnHCCLoc = new System.Windows.Forms.Button();
            this.txbHCCLoc = new System.Windows.Forms.TextBox();
            this.lblHCCLoc = new System.Windows.Forms.Label();
            this.ttpToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(261, 255);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(180, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTextEditorLoc);
            this.groupBox1.Controls.Add(this.txbTextEditorLoc);
            this.groupBox1.Controls.Add(this.lblTExtEditor);
            this.groupBox1.Controls.Add(this.btnDccLoc);
            this.groupBox1.Controls.Add(this.txbDCCLoc);
            this.groupBox1.Controls.Add(this.lblDccLoc);
            this.groupBox1.Controls.Add(this.btnHCCLoc);
            this.groupBox1.Controls.Add(this.txbHCCLoc);
            this.groupBox1.Controls.Add(this.lblHCCLoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HCC Settings";
            // 
            // btnTextEditorLoc
            // 
            this.btnTextEditorLoc.Image = global::HexCCGUI.Properties.Resources.folder_Open_16xLG;
            this.btnTextEditorLoc.Location = new System.Drawing.Point(268, 167);
            this.btnTextEditorLoc.Name = "btnTextEditorLoc";
            this.btnTextEditorLoc.Size = new System.Drawing.Size(31, 23);
            this.btnTextEditorLoc.TabIndex = 8;
            this.ttpToolTips.SetToolTip(this.btnTextEditorLoc, "Browse to your text editor");
            this.btnTextEditorLoc.UseVisualStyleBackColor = true;
            this.btnTextEditorLoc.Click += new System.EventHandler(this.btnTextEditorLoc_Click);
            // 
            // txbTextEditorLoc
            // 
            this.txbTextEditorLoc.Location = new System.Drawing.Point(24, 170);
            this.txbTextEditorLoc.Name = "txbTextEditorLoc";
            this.txbTextEditorLoc.Size = new System.Drawing.Size(237, 20);
            this.txbTextEditorLoc.TabIndex = 7;
            // 
            // lblTExtEditor
            // 
            this.lblTExtEditor.AutoSize = true;
            this.lblTExtEditor.Location = new System.Drawing.Point(21, 151);
            this.lblTExtEditor.Name = "lblTExtEditor";
            this.lblTExtEditor.Size = new System.Drawing.Size(148, 13);
            this.lblTExtEditor.TabIndex = 6;
            this.lblTExtEditor.Text = "Text Editor Location (optional)";
            // 
            // btnDccLoc
            // 
            this.btnDccLoc.Image = global::HexCCGUI.Properties.Resources.folder_Open_16xLG;
            this.btnDccLoc.Location = new System.Drawing.Point(268, 102);
            this.btnDccLoc.Name = "btnDccLoc";
            this.btnDccLoc.Size = new System.Drawing.Size(31, 23);
            this.btnDccLoc.TabIndex = 5;
            this.ttpToolTips.SetToolTip(this.btnDccLoc, "Browse to your DCC");
            this.btnDccLoc.UseVisualStyleBackColor = true;
            this.btnDccLoc.Click += new System.EventHandler(this.btnDccLoc_Click);
            // 
            // txbDCCLoc
            // 
            this.txbDCCLoc.Location = new System.Drawing.Point(24, 105);
            this.txbDCCLoc.Name = "txbDCCLoc";
            this.txbDCCLoc.Size = new System.Drawing.Size(237, 20);
            this.txbDCCLoc.TabIndex = 4;
            // 
            // lblDccLoc
            // 
            this.lblDccLoc.AutoSize = true;
            this.lblDccLoc.Location = new System.Drawing.Point(21, 86);
            this.lblDccLoc.Name = "lblDccLoc";
            this.lblDccLoc.Size = new System.Drawing.Size(175, 13);
            this.lblDccLoc.TabIndex = 3;
            this.lblDccLoc.Text = "HCC Decompiler Location (optional)";
            // 
            // btnHCCLoc
            // 
            this.btnHCCLoc.Image = global::HexCCGUI.Properties.Resources.folder_Open_16xLG;
            this.btnHCCLoc.Location = new System.Drawing.Point(268, 43);
            this.btnHCCLoc.Name = "btnHCCLoc";
            this.btnHCCLoc.Size = new System.Drawing.Size(31, 23);
            this.btnHCCLoc.TabIndex = 2;
            this.ttpToolTips.SetToolTip(this.btnHCCLoc, "Browse to your HCC");
            this.btnHCCLoc.UseVisualStyleBackColor = true;
            this.btnHCCLoc.Click += new System.EventHandler(this.btnHCCLoc_Click);
            // 
            // txbHCCLoc
            // 
            this.txbHCCLoc.Location = new System.Drawing.Point(24, 46);
            this.txbHCCLoc.Name = "txbHCCLoc";
            this.txbHCCLoc.Size = new System.Drawing.Size(237, 20);
            this.txbHCCLoc.TabIndex = 1;
            // 
            // lblHCCLoc
            // 
            this.lblHCCLoc.AutoSize = true;
            this.lblHCCLoc.Location = new System.Drawing.Point(21, 27);
            this.lblHCCLoc.Name = "lblHCCLoc";
            this.lblHCCLoc.Size = new System.Drawing.Size(73, 13);
            this.lblHCCLoc.TabIndex = 0;
            this.lblHCCLoc.Text = "HCC Location";
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(348, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDccLoc;
        private System.Windows.Forms.TextBox txbDCCLoc;
        private System.Windows.Forms.Label lblDccLoc;
        private System.Windows.Forms.Button btnHCCLoc;
        private System.Windows.Forms.TextBox txbHCCLoc;
        private System.Windows.Forms.Label lblHCCLoc;
        private System.Windows.Forms.Button btnTextEditorLoc;
        private System.Windows.Forms.TextBox txbTextEditorLoc;
        private System.Windows.Forms.Label lblTExtEditor;
        private System.Windows.Forms.ToolTip ttpToolTips;
    }
}