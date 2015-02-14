namespace ReplaceUkr2Eng
{
    partial class FormMainReplace
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
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.openFileDialogTranslations = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoadTranslations = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSource = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(81, 36);
            this.textBoxSource.MaxLength = 0;
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSource.Size = new System.Drawing.Size(692, 219);
            this.textBoxSource.TabIndex = 1;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(81, 276);
            this.textBoxResult.MaxLength = 0;
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(692, 220);
            this.textBoxResult.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemReplace,
            this.toolStripMenuItemLoadTranslations});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(795, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemReplace
            // 
            this.toolStripMenuItemReplace.CheckOnClick = true;
            this.toolStripMenuItemReplace.Name = "toolStripMenuItemReplace";
            this.toolStripMenuItemReplace.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItemReplace.Text = "Replace";
            this.toolStripMenuItemReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // toolStripMenuItemLoadTranslations
            // 
            this.toolStripMenuItemLoadTranslations.Name = "toolStripMenuItemLoadTranslations";
            this.toolStripMenuItemLoadTranslations.Size = new System.Drawing.Size(100, 20);
            this.toolStripMenuItemLoadTranslations.Text = "LoadTranslations";
            this.toolStripMenuItemLoadTranslations.Click += new System.EventHandler(this.buttonReadTranslationPairs_Click);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(10, 39);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(65, 13);
            this.labelSource.TabIndex = 5;
            this.labelSource.Text = "Source Text";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(38, 279);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(795, 22);
            this.statusStrip.TabIndex = 7;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // FormMainReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMainReplace";
            this.Text = "Ukrainian to English phrases replace tool";
            this.SizeChanged += new System.EventHandler(this.FormMainReplace_Resized);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.OpenFileDialog openFileDialogTranslations;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReplace;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadTranslations;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

