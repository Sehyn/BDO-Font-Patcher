namespace Universal_Font_Patcher_BDO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.BtnExit = new Siticone.UI.WinForms.SiticoneButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.BtnContinue = new Siticone.UI.WinForms.SiticoneButton();
            this.gunaAnimateWindow1 = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.TxtGamePath = new Siticone.UI.WinForms.SiticoneTextBox();
            this.TxtFontPath = new Siticone.UI.WinForms.SiticoneTextBox();
            this.BtnSelectGameFolder = new Siticone.UI.WinForms.SiticoneButton();
            this.BtnSelectFont = new Siticone.UI.WinForms.SiticoneButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(10, 11);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(163, 14);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Universal Font Patcher [BDO]";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.gunaPanel1.Controls.Add(this.BtnExit);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(478, 38);
            this.gunaPanel1.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.CheckedState.Parent = this.BtnExit;
            this.BtnExit.CustomImages.Parent = this.BtnExit;
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.HoveredState.Parent = this.BtnExit;
            this.BtnExit.Location = new System.Drawing.Point(421, 7);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Parent = this.BtnExit;
            this.BtnExit.Size = new System.Drawing.Size(51, 24);
            this.BtnExit.TabIndex = 26;
            this.BtnExit.Text = "X";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(6, 41);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(0, 14);
            this.gunaLabel2.TabIndex = 24;
            // 
            // BtnContinue
            // 
            this.BtnContinue.BorderRadius = 3;
            this.BtnContinue.CheckedState.Parent = this.BtnContinue;
            this.BtnContinue.CustomImages.Parent = this.BtnContinue;
            this.BtnContinue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnContinue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.ForeColor = System.Drawing.Color.White;
            this.BtnContinue.HoveredState.Parent = this.BtnContinue;
            this.BtnContinue.Location = new System.Drawing.Point(13, 128);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.ShadowDecoration.Parent = this.BtnContinue;
            this.BtnContinue.Size = new System.Drawing.Size(459, 30);
            this.BtnContinue.TabIndex = 25;
            this.BtnContinue.Text = "Use selected font";
            this.BtnContinue.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // gunaAnimateWindow1
            // 
            this.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER;
            this.gunaAnimateWindow1.Interval = 100;
            this.gunaAnimateWindow1.TargetControl = this;
            // 
            // TxtGamePath
            // 
            this.TxtGamePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGamePath.DefaultText = "C:\\..";
            this.TxtGamePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtGamePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtGamePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtGamePath.DisabledState.Parent = this.TxtGamePath;
            this.TxtGamePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtGamePath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TxtGamePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtGamePath.FocusedState.Parent = this.TxtGamePath;
            this.TxtGamePath.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtGamePath.HoveredState.Parent = this.TxtGamePath;
            this.TxtGamePath.Location = new System.Drawing.Point(195, 44);
            this.TxtGamePath.Name = "TxtGamePath";
            this.TxtGamePath.PasswordChar = '\0';
            this.TxtGamePath.PlaceholderText = "";
            this.TxtGamePath.ReadOnly = true;
            this.TxtGamePath.SelectedText = "";
            this.TxtGamePath.ShadowDecoration.Parent = this.TxtGamePath;
            this.TxtGamePath.Size = new System.Drawing.Size(277, 36);
            this.TxtGamePath.TabIndex = 28;
            // 
            // TxtFontPath
            // 
            this.TxtFontPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtFontPath.DefaultText = "C:\\..";
            this.TxtFontPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtFontPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtFontPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFontPath.DisabledState.Parent = this.TxtFontPath;
            this.TxtFontPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtFontPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TxtFontPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFontPath.FocusedState.Parent = this.TxtFontPath;
            this.TxtFontPath.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtFontPath.HoveredState.Parent = this.TxtFontPath;
            this.TxtFontPath.Location = new System.Drawing.Point(195, 86);
            this.TxtFontPath.Name = "TxtFontPath";
            this.TxtFontPath.PasswordChar = '\0';
            this.TxtFontPath.PlaceholderText = "";
            this.TxtFontPath.ReadOnly = true;
            this.TxtFontPath.SelectedText = "";
            this.TxtFontPath.ShadowDecoration.Parent = this.TxtFontPath;
            this.TxtFontPath.Size = new System.Drawing.Size(277, 36);
            this.TxtFontPath.TabIndex = 29;
            // 
            // BtnSelectGameFolder
            // 
            this.BtnSelectGameFolder.BorderRadius = 3;
            this.BtnSelectGameFolder.CheckedState.Parent = this.BtnSelectGameFolder;
            this.BtnSelectGameFolder.CustomImages.Parent = this.BtnSelectGameFolder;
            this.BtnSelectGameFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnSelectGameFolder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectGameFolder.ForeColor = System.Drawing.Color.White;
            this.BtnSelectGameFolder.HoveredState.Parent = this.BtnSelectGameFolder;
            this.BtnSelectGameFolder.Location = new System.Drawing.Point(12, 44);
            this.BtnSelectGameFolder.Name = "BtnSelectGameFolder";
            this.BtnSelectGameFolder.ShadowDecoration.Parent = this.BtnSelectGameFolder;
            this.BtnSelectGameFolder.Size = new System.Drawing.Size(177, 36);
            this.BtnSelectGameFolder.TabIndex = 30;
            this.BtnSelectGameFolder.Text = "Select game folder";
            this.BtnSelectGameFolder.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.BtnSelectGameFolder.Click += new System.EventHandler(this.BtnSelectGameFolder_Click);
            // 
            // BtnSelectFont
            // 
            this.BtnSelectFont.BorderRadius = 3;
            this.BtnSelectFont.CheckedState.Parent = this.BtnSelectFont;
            this.BtnSelectFont.CustomImages.Parent = this.BtnSelectFont;
            this.BtnSelectFont.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BtnSelectFont.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectFont.ForeColor = System.Drawing.Color.White;
            this.BtnSelectFont.HoveredState.Parent = this.BtnSelectFont;
            this.BtnSelectFont.Location = new System.Drawing.Point(12, 86);
            this.BtnSelectFont.Name = "BtnSelectFont";
            this.BtnSelectFont.ShadowDecoration.Parent = this.BtnSelectFont;
            this.BtnSelectFont.Size = new System.Drawing.Size(177, 36);
            this.BtnSelectFont.TabIndex = 31;
            this.BtnSelectFont.Text = "Select font";
            this.BtnSelectFont.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.BtnSelectFont.Click += new System.EventHandler(this.BtnSelectFont_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(12, 161);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(45, 13);
            this.gunaLabel3.TabIndex = 32;
            this.gunaLabel3.Text = "@Sehyn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(478, 182);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.BtnSelectFont);
            this.Controls.Add(this.BtnSelectGameFolder);
            this.Controls.Add(this.TxtFontPath);
            this.Controls.Add(this.TxtGamePath);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UFP - TERMS";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Siticone.UI.WinForms.SiticoneButton BtnContinue;
        private Siticone.UI.WinForms.SiticoneButton BtnExit;
        private Guna.UI.WinForms.GunaAnimateWindow gunaAnimateWindow1;
        private Siticone.UI.WinForms.SiticoneButton BtnSelectFont;
        private Siticone.UI.WinForms.SiticoneButton BtnSelectGameFolder;
        private Siticone.UI.WinForms.SiticoneTextBox TxtFontPath;
        private Siticone.UI.WinForms.SiticoneTextBox TxtGamePath;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

