﻿namespace Däckarn
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
            schemaToolStripMenuItem = new ToolStripMenuItem();
            hanteraSchemaToolStripMenuItem = new ToolStripMenuItem();
            bokningarToolStripMenuItem = new ToolStripMenuItem();
            läggTillBokningToolStripMenuItem = new ToolStripMenuItem();
            hanteraBokningarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            taBortBokningToolStripMenuItem = new ToolStripMenuItem();
            hjälpToolStripMenuItem = new ToolStripMenuItem();
            omToolStripMenuItem = new ToolStripMenuItem();
            listView1 = new ListView();
            columnDone = new ColumnHeader();
            columnName = new ColumnHeader();
            columnPremium = new ColumnHeader();
            columnRegNr = new ColumnHeader();
            columnCar = new ColumnHeader();
            label1 = new Label();
            lblDay = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arkivToolStripMenuItem, schemaToolStripMenuItem, bokningarToolStripMenuItem, hjälpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(778, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            arkivToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avslutaToolStripMenuItem });
            arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            arkivToolStripMenuItem.Size = new Size(56, 24);
            arkivToolStripMenuItem.Text = "&Arkiv";
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(140, 26);
            avslutaToolStripMenuItem.Text = "&Avsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // schemaToolStripMenuItem
            // 
            schemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hanteraSchemaToolStripMenuItem });
            schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            schemaToolStripMenuItem.Size = new Size(75, 24);
            schemaToolStripMenuItem.Text = "&Schema";
            // 
            // hanteraSchemaToolStripMenuItem
            // 
            hanteraSchemaToolStripMenuItem.Name = "hanteraSchemaToolStripMenuItem";
            hanteraSchemaToolStripMenuItem.ShortcutKeys = Keys.F5;
            hanteraSchemaToolStripMenuItem.Size = new Size(225, 26);
            hanteraSchemaToolStripMenuItem.Text = "&Hantera Schema";
            hanteraSchemaToolStripMenuItem.Click += hanteraSchemaToolStripMenuItem_Click;
            // 
            // bokningarToolStripMenuItem
            // 
            bokningarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { läggTillBokningToolStripMenuItem, hanteraBokningarToolStripMenuItem, toolStripMenuItem1, taBortBokningToolStripMenuItem });
            bokningarToolStripMenuItem.Name = "bokningarToolStripMenuItem";
            bokningarToolStripMenuItem.Size = new Size(90, 24);
            bokningarToolStripMenuItem.Text = "&Bokningar";
            // 
            // läggTillBokningToolStripMenuItem
            // 
            läggTillBokningToolStripMenuItem.Name = "läggTillBokningToolStripMenuItem";
            läggTillBokningToolStripMenuItem.ShortcutKeys = Keys.F1;
            läggTillBokningToolStripMenuItem.Size = new Size(240, 26);
            läggTillBokningToolStripMenuItem.Text = "&Lägg till Bokning";
            läggTillBokningToolStripMenuItem.Click += läggTillBokningToolStripMenuItem_Click;
            // 
            // hanteraBokningarToolStripMenuItem
            // 
            hanteraBokningarToolStripMenuItem.Name = "hanteraBokningarToolStripMenuItem";
            hanteraBokningarToolStripMenuItem.ShortcutKeys = Keys.F2;
            hanteraBokningarToolStripMenuItem.Size = new Size(240, 26);
            hanteraBokningarToolStripMenuItem.Text = "&Hantera Bokningar";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(237, 6);
            // 
            // taBortBokningToolStripMenuItem
            // 
            taBortBokningToolStripMenuItem.Name = "taBortBokningToolStripMenuItem";
            taBortBokningToolStripMenuItem.Size = new Size(240, 26);
            taBortBokningToolStripMenuItem.Text = "&Ta bort Bokning";
            // 
            // hjälpToolStripMenuItem
            // 
            hjälpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { omToolStripMenuItem });
            hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            hjälpToolStripMenuItem.Size = new Size(59, 24);
            hjälpToolStripMenuItem.Text = "&Hjälp";
            // 
            // omToolStripMenuItem
            // 
            omToolStripMenuItem.Name = "omToolStripMenuItem";
            omToolStripMenuItem.Size = new Size(116, 26);
            omToolStripMenuItem.Text = "&Om";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnDone, columnName, columnPremium, columnRegNr, columnCar });
            listView1.Location = new Point(14, 69);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(748, 373);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnDone
            // 
            columnDone.Text = "Genomförd";
            columnDone.Width = 90;
            // 
            // columnName
            // 
            columnName.Text = "Namn";
            columnName.TextAlign = HorizontalAlignment.Center;
            columnName.Width = 250;
            // 
            // columnPremium
            // 
            columnPremium.Text = "Premium";
            columnPremium.TextAlign = HorizontalAlignment.Center;
            columnPremium.Width = 80;
            // 
            // columnRegNr
            // 
            columnRegNr.Text = "Reg. Nr";
            columnRegNr.TextAlign = HorizontalAlignment.Center;
            columnRegNr.Width = 70;
            // 
            // columnCar
            // 
            columnCar.Text = "Bil";
            columnCar.TextAlign = HorizontalAlignment.Center;
            columnCar.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 45);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Bokningar Idag";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.Location = new Point(487, 32);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(0, 32);
            lblDay.TabIndex = 3;
            lblDay.TextAlign = ContentAlignment.TopRight;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 468);
            Controls.Add(lblDay);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Däckarn";
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arkivToolStripMenuItem;
        private ToolStripMenuItem avslutaToolStripMenuItem;
        private ListView listView1;
        private Label label1;
        private ColumnHeader columnName;
        private ColumnHeader columnPremium;
        private ColumnHeader columnRegNr;
        private ColumnHeader columnCar;
        private ColumnHeader columnDone;
        private Label lblDay;
        private ToolStripMenuItem bokningarToolStripMenuItem;
        private ToolStripMenuItem läggTillBokningToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem taBortBokningToolStripMenuItem;
        private ToolStripMenuItem hanteraBokningarToolStripMenuItem;
        private ToolStripMenuItem hjälpToolStripMenuItem;
        private ToolStripMenuItem omToolStripMenuItem;
        private ToolStripMenuItem schemaToolStripMenuItem;
        private ToolStripMenuItem hanteraSchemaToolStripMenuItem;
    }
}