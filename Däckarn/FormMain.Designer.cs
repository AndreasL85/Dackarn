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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            listViewBookings = new ListView();
            columnDate = new ColumnHeader();
            columnDone = new ColumnHeader();
            columnName = new ColumnHeader();
            columnPremium = new ColumnHeader();
            columnRegNr = new ColumnHeader();
            columnCar = new ColumnHeader();
            label1 = new Label();
            lblDay = new Label();
            buttonDone = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { arkivToolStripMenuItem, schemaToolStripMenuItem, bokningarToolStripMenuItem, hjälpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(819, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            arkivToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { avslutaToolStripMenuItem });
            arkivToolStripMenuItem.Image = Properties.Resources.icons8_tire_64;
            arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            arkivToolStripMenuItem.Size = new Size(66, 24);
            arkivToolStripMenuItem.Text = "&Arkiv";
            // 
            // avslutaToolStripMenuItem
            // 
            avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            avslutaToolStripMenuItem.Size = new Size(113, 22);
            avslutaToolStripMenuItem.Text = "&Avsluta";
            avslutaToolStripMenuItem.Click += avslutaToolStripMenuItem_Click;
            // 
            // schemaToolStripMenuItem
            // 
            schemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hanteraSchemaToolStripMenuItem });
            schemaToolStripMenuItem.Image = Properties.Resources.icons8_schedule_80;
            schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            schemaToolStripMenuItem.Size = new Size(81, 24);
            schemaToolStripMenuItem.Text = "&Schema";
            // 
            // hanteraSchemaToolStripMenuItem
            // 
            hanteraSchemaToolStripMenuItem.Name = "hanteraSchemaToolStripMenuItem";
            hanteraSchemaToolStripMenuItem.ShortcutKeys = Keys.F5;
            hanteraSchemaToolStripMenuItem.Size = new Size(180, 22);
            hanteraSchemaToolStripMenuItem.Text = "&Visa Schema";
            hanteraSchemaToolStripMenuItem.Click += hanteraSchemaToolStripMenuItem_Click;
            // 
            // bokningarToolStripMenuItem
            // 
            bokningarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { läggTillBokningToolStripMenuItem, hanteraBokningarToolStripMenuItem, toolStripMenuItem1, taBortBokningToolStripMenuItem });
            bokningarToolStripMenuItem.Image = Properties.Resources.icons8_booking_64;
            bokningarToolStripMenuItem.Name = "bokningarToolStripMenuItem";
            bokningarToolStripMenuItem.Size = new Size(93, 24);
            bokningarToolStripMenuItem.Text = "&Bokningar";
            // 
            // läggTillBokningToolStripMenuItem
            // 
            läggTillBokningToolStripMenuItem.Name = "läggTillBokningToolStripMenuItem";
            läggTillBokningToolStripMenuItem.ShortcutKeys = Keys.F1;
            läggTillBokningToolStripMenuItem.Size = new Size(192, 22);
            läggTillBokningToolStripMenuItem.Text = "&Lägg till Bokning";
            läggTillBokningToolStripMenuItem.Click += läggTillBokningToolStripMenuItem_Click;
            // 
            // hanteraBokningarToolStripMenuItem
            // 
            hanteraBokningarToolStripMenuItem.Name = "hanteraBokningarToolStripMenuItem";
            hanteraBokningarToolStripMenuItem.ShortcutKeys = Keys.F2;
            hanteraBokningarToolStripMenuItem.Size = new Size(192, 22);
            hanteraBokningarToolStripMenuItem.Text = "&Hantera Bokningar";
            hanteraBokningarToolStripMenuItem.Click += hanteraBokningarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(189, 6);
            // 
            // taBortBokningToolStripMenuItem
            // 
            taBortBokningToolStripMenuItem.Name = "taBortBokningToolStripMenuItem";
            taBortBokningToolStripMenuItem.ShortcutKeys = Keys.Delete;
            taBortBokningToolStripMenuItem.Size = new Size(192, 22);
            taBortBokningToolStripMenuItem.Text = "&Ta bort Bokning";
            taBortBokningToolStripMenuItem.Click += taBortBokningToolStripMenuItem_Click;
            // 
            // hjälpToolStripMenuItem
            // 
            hjälpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { omToolStripMenuItem });
            hjälpToolStripMenuItem.Image = Properties.Resources.icons8_help_50;
            hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            hjälpToolStripMenuItem.Size = new Size(67, 24);
            hjälpToolStripMenuItem.Text = "&Hjälp";
            // 
            // omToolStripMenuItem
            // 
            omToolStripMenuItem.Name = "omToolStripMenuItem";
            omToolStripMenuItem.Size = new Size(180, 22);
            omToolStripMenuItem.Text = "&Om";
            omToolStripMenuItem.Click += omToolStripMenuItem_Click;
            // 
            // listViewBookings
            // 
            listViewBookings.Columns.AddRange(new ColumnHeader[] { columnDate, columnDone, columnName, columnPremium, columnRegNr, columnCar });
            listViewBookings.FullRowSelect = true;
            listViewBookings.GridLines = true;
            listViewBookings.Location = new Point(12, 52);
            listViewBookings.MultiSelect = false;
            listViewBookings.Name = "listViewBookings";
            listViewBookings.Size = new Size(794, 359);
            listViewBookings.Sorting = SortOrder.Ascending;
            listViewBookings.TabIndex = 1;
            listViewBookings.UseCompatibleStateImageBehavior = false;
            listViewBookings.View = View.Details;
            // 
            // columnDate
            // 
            columnDate.Text = "Tid";
            // 
            // columnDone
            // 
            columnDone.Text = "Genomförd";
            columnDone.TextAlign = HorizontalAlignment.Center;
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
            columnCar.Width = 240;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Bokningar Idag";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDay.Location = new Point(316, 26);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(0, 25);
            lblDay.TabIndex = 3;
            lblDay.TextAlign = ContentAlignment.TopRight;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(12, 417);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 23);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Klar";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 447);
            Controls.Add(buttonDone);
            Controls.Add(lblDay);
            Controls.Add(label1);
            Controls.Add(listViewBookings);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
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
        private ListView listViewBookings;
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
        private ColumnHeader columnDate;
        private Button buttonDone;
    }
}