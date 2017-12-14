namespace BlueBird
{
    partial class ViewMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueBirdManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBlueBirdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBrowser = new System.Windows.Forms.Button();
            this.BlueBirdcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoutonCreer = new System.Windows.Forms.Button();
            this.BlueBirdtextBox = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.templatesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(609, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem3});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // templatesToolStripMenuItem
            // 
            this.templatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueBirdManagerToolStripMenuItem,
            this.contentManagerToolStripMenuItem});
            this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
            this.templatesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.templatesToolStripMenuItem.Text = "&Templates";
            this.templatesToolStripMenuItem.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBlueBirdToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "&Save";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "E&xit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // blueBirdManagerToolStripMenuItem
            // 
            this.blueBirdManagerToolStripMenuItem.Name = "blueBirdManagerToolStripMenuItem";
            this.blueBirdManagerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.blueBirdManagerToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.blueBirdManagerToolStripMenuItem.Text = "BlueBird Manager";
            this.blueBirdManagerToolStripMenuItem.Click += new System.EventHandler(this.blueBirdManagerToolStripMenuItem_Click);
            // 
            // contentManagerToolStripMenuItem
            // 
            this.contentManagerToolStripMenuItem.Name = "contentManagerToolStripMenuItem";
            this.contentManagerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.contentManagerToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.contentManagerToolStripMenuItem.Text = "Content Manager";
            // 
            // aboutBlueBirdToolStripMenuItem
            // 
            this.aboutBlueBirdToolStripMenuItem.Name = "aboutBlueBirdToolStripMenuItem";
            this.aboutBlueBirdToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutBlueBirdToolStripMenuItem.Text = "About BlueBird";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chemin Fichier";
            // 
            // ButtonBrowser
            // 
            this.ButtonBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowser.Location = new System.Drawing.Point(480, 63);
            this.ButtonBrowser.Name = "ButtonBrowser";
            this.ButtonBrowser.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowser.TabIndex = 4;
            this.ButtonBrowser.Text = "----";
            this.ButtonBrowser.UseVisualStyleBackColor = true;
            // 
            // BlueBirdcomboBox
            // 
            this.BlueBirdcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueBirdcomboBox.FormattingEnabled = true;
            this.BlueBirdcomboBox.Location = new System.Drawing.Point(345, 92);
            this.BlueBirdcomboBox.Name = "BlueBirdcomboBox";
            this.BlueBirdcomboBox.Size = new System.Drawing.Size(210, 21);
            this.BlueBirdcomboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BlueBird";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BoutonCreer
            // 
            this.BoutonCreer.Location = new System.Drawing.Point(455, 283);
            this.BoutonCreer.Name = "BoutonCreer";
            this.BoutonCreer.Size = new System.Drawing.Size(75, 23);
            this.BoutonCreer.TabIndex = 7;
            this.BoutonCreer.Text = "&Creer";
            this.BoutonCreer.UseVisualStyleBackColor = true;
            // 
            // BlueBirdtextBox
            // 
            this.BlueBirdtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlueBirdtextBox.Location = new System.Drawing.Point(15, 126);
            this.BlueBirdtextBox.Multiline = true;
            this.BlueBirdtextBox.Name = "BlueBirdtextBox";
            this.BlueBirdtextBox.Size = new System.Drawing.Size(540, 151);
            this.BlueBirdtextBox.TabIndex = 8;
            // 
            // ViewMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 368);
            this.Controls.Add(this.BlueBirdtextBox);
            this.Controls.Add(this.BoutonCreer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BlueBirdcomboBox);
            this.Controls.Add(this.ButtonBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewMain";
            this.Text = "BlueBird";
            this.Load += new System.EventHandler(this.ViewMain_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem blueBirdManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBlueBirdToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonBrowser;
        private System.Windows.Forms.ComboBox BlueBirdcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BoutonCreer;
        private System.Windows.Forms.TextBox BlueBirdtextBox;
    }
}

