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
            labelBookingDate = new Label();
            buttonPickDate = new Button();
            buttonBoka = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Namn:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 49);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 1;
            // 
            // chkPremium
            // 
            chkPremium.AutoSize = true;
            chkPremium.Location = new Point(14, 88);
            chkPremium.Margin = new Padding(3, 4, 3, 4);
            chkPremium.Name = "chkPremium";
            chkPremium.Size = new Size(128, 24);
            chkPremium.TabIndex = 2;
            chkPremium.Text = "Premium Kund";
            chkPremium.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 143);
            label2.Name = "label2";
            label2.Size = new Size(246, 20);
            label2.TabIndex = 3;
            label2.Text = "Registreringsnummer (t.ex ABC123):";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 167);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.MaxLength = 6;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(293, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 205);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Bilmärke:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 229);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 27);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 268);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 7;
            label4.Text = "Bilmodell:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(14, 292);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 27);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 331);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 9;
            label5.Text = "Årsmodell:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(14, 355);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(293, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 393);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 11;
            label6.Text = "Tjänst:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Däckbyte (Nya Däck)", "Däckhotell inkl. Hjulbyte", "Hjulbyte till Vinterdäck", "Hjulbyte till Sommardäck", "Hjulinställning" });
            comboBox1.Location = new Point(14, 417);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 28);
            comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 476);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 13;
            label7.Text = "Datum:";
            // 
            // labelBookingDate
            // 
            labelBookingDate.AutoSize = true;
            labelBookingDate.Location = new Point(14, 503);
            labelBookingDate.Name = "labelBookingDate";
            labelBookingDate.Size = new Size(0, 20);
            labelBookingDate.TabIndex = 14;
            // 
            // buttonPickDate
            // 
            buttonPickDate.Location = new Point(213, 468);
            buttonPickDate.Margin = new Padding(3, 4, 3, 4);
            buttonPickDate.Name = "buttonPickDate";
            buttonPickDate.Size = new Size(95, 31);
            buttonPickDate.TabIndex = 15;
            buttonPickDate.Text = "Välj datum";
            buttonPickDate.UseVisualStyleBackColor = true;
            buttonPickDate.Click += buttonPickDate_Click;
            // 
            // buttonBoka
            // 
            buttonBoka.Location = new Point(14, 559);
            buttonBoka.Margin = new Padding(3, 4, 3, 4);
            buttonBoka.Name = "buttonBoka";
            buttonBoka.Size = new Size(106, 31);
            buttonBoka.TabIndex = 16;
            buttonBoka.Text = "Boka";
            buttonBoka.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(222, 559);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 31);
            buttonCancel.TabIndex = 17;
            buttonCancel.Text = "Avbryt";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormAddBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 609);
            Controls.Add(buttonCancel);
            Controls.Add(buttonBoka);
            Controls.Add(buttonPickDate);
            Controls.Add(labelBookingDate);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label labelBookingDate;
        private Button buttonPickDate;
        private Button buttonBoka;
        private Button buttonCancel;
    }
}