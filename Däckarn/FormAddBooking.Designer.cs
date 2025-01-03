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
            textBox1 = new TextBox();
            chkPremium = new CheckBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            buttonPickDate = new Button();
            buttonBoka = new Button();
            buttonCancel = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 23);
            textBox1.TabIndex = 1;
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
            // textBox2
            // 
            textBox2.Location = new Point(12, 125);
            textBox2.MaxLength = 6;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 23);
            textBox2.TabIndex = 4;
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
            // textBox3
            // 
            textBox3.Location = new Point(12, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(257, 23);
            textBox3.TabIndex = 6;
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
            // textBox4
            // 
            textBox4.Location = new Point(12, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(257, 23);
            textBox4.TabIndex = 8;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 266);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 23);
            dateTimePicker1.TabIndex = 10;
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Däckbyte (Nya Däck)", "Däckhotell inkl. Hjulbyte", "Hjulbyte till Vinterdäck", "Hjulbyte till Sommardäck", "Hjulinställning" });
            comboBox1.Location = new Point(12, 313);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(257, 23);
            comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 339);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 13;
            label7.Text = "Datum:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 355);
            label8.Name = "label8";
            label8.Size = new Size(118, 15);
            label8.TabIndex = 14;
            label8.Text = "fredag den 3e januari";
            // 
            // buttonPickDate
            // 
            buttonPickDate.Location = new Point(194, 351);
            buttonPickDate.Name = "buttonPickDate";
            buttonPickDate.Size = new Size(75, 23);
            buttonPickDate.TabIndex = 15;
            buttonPickDate.Text = "Välj datum";
            buttonPickDate.UseVisualStyleBackColor = true;
            buttonPickDate.Click += buttonPickDate_Click;
            // 
            // buttonBoka
            // 
            buttonBoka.Location = new Point(12, 397);
            buttonBoka.Name = "buttonBoka";
            buttonBoka.Size = new Size(75, 23);
            buttonBoka.TabIndex = 16;
            buttonBoka.Text = "Boka";
            buttonBoka.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(194, 397);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "Avbryt";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormAddBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 431);
            Controls.Add(buttonCancel);
            Controls.Add(buttonBoka);
            Controls.Add(buttonPickDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(chkPremium);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddBooking";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lägg till Bokning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private CheckBox chkPremium;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private Button buttonPickDate;
        private Button buttonBoka;
        private Button buttonCancel;
    }
}