namespace Däckarn
{
    partial class FormEditBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditBooking));
            comboBoxYear = new ComboBox();
            buttonCancel = new Button();
            buttonUpdateBooking = new Button();
            buttonPickDate = new Button();
            labelBookingDate = new Label();
            label7 = new Label();
            comboBoxService = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            textBoxModel = new TextBox();
            label4 = new Label();
            textBoxBrand = new TextBox();
            label3 = new Label();
            textBoxRegNr = new TextBox();
            label2 = new Label();
            chkPremium = new CheckBox();
            textBoxName = new TextBox();
            label1 = new Label();
            listViewBookings = new ListView();
            columnDate = new ColumnHeader();
            columnDone = new ColumnHeader();
            columnName = new ColumnHeader();
            columnPremium = new ColumnHeader();
            columnRegNr = new ColumnHeader();
            columnCar = new ColumnHeader();
            SuspendLayout();
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(810, 258);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(257, 23);
            comboBoxYear.TabIndex = 23;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(810, 495);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(257, 23);
            buttonCancel.TabIndex = 29;
            buttonCancel.Text = "Stäng";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonUpdateBooking
            // 
            buttonUpdateBooking.Location = new Point(810, 411);
            buttonUpdateBooking.Name = "buttonUpdateBooking";
            buttonUpdateBooking.Size = new Size(255, 23);
            buttonUpdateBooking.TabIndex = 27;
            buttonUpdateBooking.Text = "Uppdatera";
            buttonUpdateBooking.UseVisualStyleBackColor = true;
            buttonUpdateBooking.Click += buttonUpdateBooking_Click;
            // 
            // buttonPickDate
            // 
            buttonPickDate.Location = new Point(984, 343);
            buttonPickDate.Name = "buttonPickDate";
            buttonPickDate.Size = new Size(83, 23);
            buttonPickDate.TabIndex = 26;
            buttonPickDate.Text = "Välj datum";
            buttonPickDate.UseVisualStyleBackColor = true;
            buttonPickDate.Click += buttonPickDate_Click;
            // 
            // labelBookingDate
            // 
            labelBookingDate.AutoSize = true;
            labelBookingDate.Location = new Point(812, 377);
            labelBookingDate.Name = "labelBookingDate";
            labelBookingDate.Size = new Size(0, 15);
            labelBookingDate.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(810, 349);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 31;
            label7.Text = "Datum:";
            // 
            // comboBoxService
            // 
            comboBoxService.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxService.FormattingEnabled = true;
            comboBoxService.Items.AddRange(new object[] { "Däckbyte (Nya Däck)", "Däckhotell inkl. Hjulbyte", "Hjulbyte till Vinterdäck", "Hjulbyte till Sommardäck", "Hjulinställning" });
            comboBoxService.Location = new Point(810, 305);
            comboBoxService.Name = "comboBoxService";
            comboBoxService.Size = new Size(257, 23);
            comboBoxService.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(810, 287);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 30;
            label6.Text = "Tjänst:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(810, 240);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 28;
            label5.Text = "Årsmodell:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(810, 211);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(257, 23);
            textBoxModel.TabIndex = 22;
            textBoxModel.Tag = "Bilmodell";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(810, 193);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 25;
            label4.Text = "Bilmodell:";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(810, 164);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(257, 23);
            textBoxBrand.TabIndex = 20;
            textBoxBrand.Tag = "Bilmärke";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(810, 146);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 21;
            label3.Text = "Bilmärke:";
            // 
            // textBoxRegNr
            // 
            textBoxRegNr.Location = new Point(810, 117);
            textBoxRegNr.MaxLength = 6;
            textBoxRegNr.Name = "textBoxRegNr";
            textBoxRegNr.Size = new Size(257, 23);
            textBoxRegNr.TabIndex = 19;
            textBoxRegNr.Tag = "Registreringsnummer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(810, 99);
            label2.Name = "label2";
            label2.Size = new Size(198, 15);
            label2.TabIndex = 18;
            label2.Text = "Registreringsnummer (t.ex ABC123):";
            // 
            // chkPremium
            // 
            chkPremium.AutoSize = true;
            chkPremium.Location = new Point(810, 58);
            chkPremium.Name = "chkPremium";
            chkPremium.Size = new Size(106, 19);
            chkPremium.TabIndex = 17;
            chkPremium.Text = "Premium Kund";
            chkPremium.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(810, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(257, 23);
            textBoxName.TabIndex = 16;
            textBoxName.Tag = "Namn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(810, 11);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 15;
            label1.Text = "Namn:";
            // 
            // listViewBookings
            // 
            listViewBookings.Columns.AddRange(new ColumnHeader[] { columnDate, columnDone, columnName, columnPremium, columnRegNr, columnCar });
            listViewBookings.GridLines = true;
            listViewBookings.Location = new Point(10, 11);
            listViewBookings.Name = "listViewBookings";
            listViewBookings.Size = new Size(794, 507);
            listViewBookings.TabIndex = 33;
            listViewBookings.UseCompatibleStateImageBehavior = false;
            listViewBookings.View = View.Details;
            listViewBookings.SelectedIndexChanged += listViewBookings_SelectedIndexChanged;
            // 
            // columnDate
            // 
            columnDate.Text = "Datum/Tid";
            columnDate.Width = 100;
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
            columnCar.Width = 180;
            // 
            // FormEditBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 532);
            Controls.Add(listViewBookings);
            Controls.Add(comboBoxYear);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdateBooking);
            Controls.Add(buttonPickDate);
            Controls.Add(labelBookingDate);
            Controls.Add(label7);
            Controls.Add(comboBoxService);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxModel);
            Controls.Add(label4);
            Controls.Add(textBoxBrand);
            Controls.Add(label3);
            Controls.Add(textBoxRegNr);
            Controls.Add(label2);
            Controls.Add(chkPremium);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditBooking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Redigera Bokning";
            Load += FormEditBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxYear;
        private Button buttonCancel;
        private Button buttonUpdateBooking;
        private Button buttonPickDate;
        private Label labelBookingDate;
        private Label label7;
        private ComboBox comboBoxService;
        private Label label6;
        private Label label5;
        private TextBox textBoxModel;
        private Label label4;
        private TextBox textBoxBrand;
        private Label label3;
        private TextBox textBoxRegNr;
        private Label label2;
        private CheckBox chkPremium;
        private TextBox textBoxName;
        private Label label1;
        private ListView listViewBookings;
        private ColumnHeader columnDate;
        private ColumnHeader columnDone;
        private ColumnHeader columnName;
        private ColumnHeader columnPremium;
        private ColumnHeader columnRegNr;
        private ColumnHeader columnCar;
    }
}