namespace Däckarn
{
    partial class FormAddBooking
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
            label1 = new Label();
            textBoxName = new TextBox();
            chkPremium = new CheckBox();
            label2 = new Label();
            textBoxRegNr = new TextBox();
            label3 = new Label();
            textBoxBrand = new TextBox();
            label4 = new Label();
            textBoxModel = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxService = new ComboBox();
            label7 = new Label();
            labelBookingDate = new Label();
            buttonPickDate = new Button();
            buttonBoka = new Button();
            buttonCancel = new Button();
            comboBoxYear = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Namn:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(257, 23);
            textBoxName.TabIndex = 1;
            textBoxName.Tag = "Namn";
            // 
            // chkPremium
            // 
            chkPremium.AutoSize = true;
            chkPremium.Location = new Point(12, 66);
            chkPremium.Name = "chkPremium";
            chkPremium.Size = new Size(106, 19);
            chkPremium.TabIndex = 2;
            chkPremium.Text = "Premium Kund";
            chkPremium.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(198, 15);
            label2.TabIndex = 3;
            label2.Text = "Registreringsnummer (t.ex ABC123):";
            // 
            // textBoxRegNr
            // 
            textBoxRegNr.Location = new Point(12, 125);
            textBoxRegNr.MaxLength = 6;
            textBoxRegNr.Name = "textBoxRegNr";
            textBoxRegNr.Size = new Size(257, 23);
            textBoxRegNr.TabIndex = 3;
            textBoxRegNr.Tag = "Registreringsnummer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Bilmärke:";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(12, 172);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(257, 23);
            textBoxBrand.TabIndex = 4;
            textBoxBrand.Tag = "Bilmärke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 201);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Bilmodell:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(12, 219);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(257, 23);
            textBoxModel.TabIndex = 5;
            textBoxModel.Tag = "Bilmodell";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 248);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 9;
            label5.Text = "Årsmodell:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 295);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Tjänst:";
            // 
            // comboBoxService
            // 
            comboBoxService.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxService.FormattingEnabled = true;
            comboBoxService.Items.AddRange(new object[] { "Däckbyte (Nya Däck)", "Däckhotell inkl. Hjulbyte", "Hjulbyte till Vinterdäck", "Hjulbyte till Sommardäck", "Hjulinställning" });
            comboBoxService.Location = new Point(12, 313);
            comboBoxService.Name = "comboBoxService";
            comboBoxService.Size = new Size(257, 23);
            comboBoxService.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 357);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 13;
            label7.Text = "Datum:";
            // 
            // labelBookingDate
            // 
            labelBookingDate.AutoSize = true;
            labelBookingDate.Location = new Point(12, 377);
            labelBookingDate.Name = "labelBookingDate";
            labelBookingDate.Size = new Size(0, 15);
            labelBookingDate.TabIndex = 14;
            // 
            // buttonPickDate
            // 
            buttonPickDate.Location = new Point(186, 351);
            buttonPickDate.Name = "buttonPickDate";
            buttonPickDate.Size = new Size(83, 23);
            buttonPickDate.TabIndex = 8;
            buttonPickDate.Text = "Välj datum";
            buttonPickDate.UseVisualStyleBackColor = true;
            buttonPickDate.Click += buttonPickDate_Click;
            // 
            // buttonBoka
            // 
            buttonBoka.Location = new Point(12, 419);
            buttonBoka.Name = "buttonBoka";
            buttonBoka.Size = new Size(93, 23);
            buttonBoka.TabIndex = 9;
            buttonBoka.Text = "Boka";
            buttonBoka.UseVisualStyleBackColor = true;
            buttonBoka.Click += buttonBoka_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(194, 419);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Avbryt";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(12, 266);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(257, 23);
            comboBoxYear.TabIndex = 6;
            // 
            // FormAddBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 457);
            Controls.Add(comboBoxYear);
            Controls.Add(buttonCancel);
            Controls.Add(buttonBoka);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddBooking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lägg till Bokning";
            Load += FormAddBooking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxName;
        private CheckBox chkPremium;
        private Label label2;
        private TextBox textBoxRegNr;
        private Label label3;
        private TextBox textBoxBrand;
        private Label label4;
        private TextBox textBoxModel;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxService;
        private Label label7;
        private Label labelBookingDate;
        private Button buttonPickDate;
        private Button buttonBoka;
        private Button buttonCancel;
        private ComboBox comboBoxYear;
    }
}