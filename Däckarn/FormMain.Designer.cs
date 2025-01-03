namespace Däckarn
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arkivToolStripMenuItem = new ToolStripMenuItem();
            avslutaToolStripMenuItem = new ToolStripMenuItem();
            fghgfhToolStripMenuItem = new ToolStripMenuItem();
            dfgbdfToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arkivToolStripMenuItem, fghgfhToolStripMenuItem, dfgbdfToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(821, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            arkivToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avslutaToolStripMenuItem });
            arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            arkivToolStripMenuItem.Size = new Size(46, 20);
            arkivToolStripMenuItem.Text = "&Arkiv";
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(113, 22);
            avslutaToolStripMenuItem.Text = "&Avsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // fghgfhToolStripMenuItem
            // 
            fghgfhToolStripMenuItem.Name = "fghgfhToolStripMenuItem";
            fghgfhToolStripMenuItem.Size = new Size(55, 20);
            fghgfhToolStripMenuItem.Text = "fghgfh";
            // 
            // dfgbdfToolStripMenuItem
            // 
            dfgbdfToolStripMenuItem.Name = "dfgbdfToolStripMenuItem";
            dfgbdfToolStripMenuItem.Size = new Size(155, 20);
            dfgbdfToolStripMenuItem.Text = "chbdcgnhbfgchnfgcvhbn";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 576);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Däckarn";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arkivToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
        private ToolStripMenuItem fghgfhToolStripMenuItem;
        private ToolStripMenuItem dfgbdfToolStripMenuItem;
    }
}