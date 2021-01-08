namespace ReadAndWriteFiles.Exercice
{
    partial class FrmMain
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
            this.lstReader = new System.Windows.Forms.ListBox();
            this.rtxWriter = new System.Windows.Forms.RichTextBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnOverride = new System.Windows.Forms.Button();
            this.cboFiles = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReader
            // 
            this.lstReader.IntegralHeight = false;
            this.lstReader.Location = new System.Drawing.Point(29, 61);
            this.lstReader.Name = "lstReader";
            this.lstReader.Size = new System.Drawing.Size(299, 264);
            this.lstReader.TabIndex = 0;
            // 
            // rtxWriter
            // 
            this.rtxWriter.Location = new System.Drawing.Point(400, 61);
            this.rtxWriter.Name = "rtxWriter";
            this.rtxWriter.Size = new System.Drawing.Size(299, 149);
            this.rtxWriter.TabIndex = 1;
            this.rtxWriter.Text = "";
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(400, 231);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(141, 37);
            this.btnAppend.TabIndex = 3;
            this.btnAppend.Text = "Append to file";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnOverride
            // 
            this.btnOverride.Location = new System.Drawing.Point(558, 231);
            this.btnOverride.Name = "btnOverride";
            this.btnOverride.Size = new System.Drawing.Size(141, 37);
            this.btnOverride.TabIndex = 4;
            this.btnOverride.Text = "Override file content";
            this.btnOverride.UseVisualStyleBackColor = true;
            this.btnOverride.Click += new System.EventHandler(this.btnOverride_Click);
            // 
            // cboFiles
            // 
            this.cboFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiles.FormattingEnabled = true;
            this.cboFiles.Location = new System.Drawing.Point(29, 28);
            this.cboFiles.Name = "cboFiles";
            this.cboFiles.Size = new System.Drawing.Size(140, 21);
            this.cboFiles.TabIndex = 5;
            this.cboFiles.SelectedIndexChanged += new System.EventHandler(this.cboFiles_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(400, 288);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(299, 37);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset file";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmMain
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 374);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboFiles);
            this.Controls.Add(this.btnOverride);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.rtxWriter);
            this.Controls.Add(this.lstReader);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReader;
        private System.Windows.Forms.RichTextBox rtxWriter;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnOverride;
        private System.Windows.Forms.ComboBox cboFiles;
        private System.Windows.Forms.Button btnReset;
    }
}

