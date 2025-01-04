namespace Däckarn
{
    partial class FormPickDate
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
            monthCalendar = new MonthCalendar();
            label1 = new Label();
            radioButton8to9 = new RadioButton();
            radioButton9to10 = new RadioButton();
            radioButton10to11 = new RadioButton();
            radioButton11to12 = new RadioButton();
            radioButton12to13 = new RadioButton();
            radioButton14to15 = new RadioButton();
            radioButton15to16 = new RadioButton();
            radioButton16to17 = new RadioButton();
            buttonPick = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(21, 24);
            monthCalendar.Margin = new Padding(10, 12, 10, 12);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            monthCalendar.DateSelected += monthCalendar_DateSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 252);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "Tider";
            // 
            // radioButton8to9
            // 
            radioButton8to9.AutoSize = true;
            radioButton8to9.Location = new Point(21, 276);
            radioButton8to9.Margin = new Padding(3, 4, 3, 4);
            radioButton8to9.Name = "radioButton8to9";
            radioButton8to9.Size = new Size(98, 24);
            radioButton8to9.TabIndex = 2;
            radioButton8to9.TabStop = true;
            radioButton8to9.Tag = "8";
            radioButton8to9.Text = "8:00 - 9:00";
            radioButton8to9.UseVisualStyleBackColor = true;
            // 
            // radioButton9to10
            // 
            radioButton9to10.AutoSize = true;
            radioButton9to10.Location = new Point(21, 309);
            radioButton9to10.Margin = new Padding(3, 4, 3, 4);
            radioButton9to10.Name = "radioButton9to10";
            radioButton9to10.Size = new Size(106, 24);
            radioButton9to10.TabIndex = 3;
            radioButton9to10.TabStop = true;
            radioButton9to10.Tag = "9";
            radioButton9to10.Text = "9:00 - 10:00";
            radioButton9to10.UseVisualStyleBackColor = true;
            // 
            // radioButton10to11
            // 
            radioButton10to11.AutoSize = true;
            radioButton10to11.Location = new Point(21, 343);
            radioButton10to11.Margin = new Padding(3, 4, 3, 4);
            radioButton10to11.Name = "radioButton10to11";
            radioButton10to11.Size = new Size(114, 24);
            radioButton10to11.TabIndex = 4;
            radioButton10to11.TabStop = true;
            radioButton10to11.Tag = "10";
            radioButton10to11.Text = "10:00 - 11:00";
            radioButton10to11.UseVisualStyleBackColor = true;
            // 
            // radioButton11to12
            // 
            radioButton11to12.AutoSize = true;
            radioButton11to12.Location = new Point(21, 376);
            radioButton11to12.Margin = new Padding(3, 4, 3, 4);
            radioButton11to12.Name = "radioButton11to12";
            radioButton11to12.Size = new Size(114, 24);
            radioButton11to12.TabIndex = 5;
            radioButton11to12.TabStop = true;
            radioButton11to12.Tag = "11";
            radioButton11to12.Text = "11:00 - 12:00";
            radioButton11to12.UseVisualStyleBackColor = true;
            // 
            // radioButton12to13
            // 
            radioButton12to13.AutoSize = true;
            radioButton12to13.Location = new Point(21, 409);
            radioButton12to13.Margin = new Padding(3, 4, 3, 4);
            radioButton12to13.Name = "radioButton12to13";
            radioButton12to13.Size = new Size(114, 24);
            radioButton12to13.TabIndex = 6;
            radioButton12to13.TabStop = true;
            radioButton12to13.Tag = "12";
            radioButton12to13.Text = "12:00 - 13:00";
            radioButton12to13.UseVisualStyleBackColor = true;
            // 
            // radioButton14to15
            // 
            radioButton14to15.AutoSize = true;
            radioButton14to15.Location = new Point(21, 443);
            radioButton14to15.Margin = new Padding(3, 4, 3, 4);
            radioButton14to15.Name = "radioButton14to15";
            radioButton14to15.Size = new Size(114, 24);
            radioButton14to15.TabIndex = 7;
            radioButton14to15.TabStop = true;
            radioButton14to15.Tag = "14";
            radioButton14to15.Text = "14:00 - 15:00";
            radioButton14to15.UseVisualStyleBackColor = true;
            // 
            // radioButton15to16
            // 
            radioButton15to16.AutoSize = true;
            radioButton15to16.Location = new Point(21, 476);
            radioButton15to16.Margin = new Padding(3, 4, 3, 4);
            radioButton15to16.Name = "radioButton15to16";
            radioButton15to16.Size = new Size(114, 24);
            radioButton15to16.TabIndex = 8;
            radioButton15to16.TabStop = true;
            radioButton15to16.Tag = "15";
            radioButton15to16.Text = "15:00 - 16:00";
            radioButton15to16.UseVisualStyleBackColor = true;
            // 
            // radioButton16to17
            // 
            radioButton16to17.AutoSize = true;
            radioButton16to17.Location = new Point(21, 509);
            radioButton16to17.Margin = new Padding(3, 4, 3, 4);
            radioButton16to17.Name = "radioButton16to17";
            radioButton16to17.Size = new Size(114, 24);
            radioButton16to17.TabIndex = 9;
            radioButton16to17.TabStop = true;
            radioButton16to17.Tag = "16";
            radioButton16to17.Text = "16:00 - 17:00";
            radioButton16to17.UseVisualStyleBackColor = true;
            // 
            // buttonPick
            // 
            buttonPick.Location = new Point(21, 561);
            buttonPick.Margin = new Padding(3, 4, 3, 4);
            buttonPick.Name = "buttonPick";
            buttonPick.Size = new Size(86, 31);
            buttonPick.TabIndex = 10;
            buttonPick.Text = "Välj";
            buttonPick.UseVisualStyleBackColor = true;
            buttonPick.Click += buttonPick_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(182, 562);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Avbryt";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormPickDate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 607);
            Controls.Add(buttonCancel);
            Controls.Add(buttonPick);
            Controls.Add(radioButton16to17);
            Controls.Add(radioButton15to16);
            Controls.Add(radioButton14to15);
            Controls.Add(radioButton12to13);
            Controls.Add(radioButton11to12);
            Controls.Add(radioButton10to11);
            Controls.Add(radioButton9to10);
            Controls.Add(radioButton8to9);
            Controls.Add(label1);
            Controls.Add(monthCalendar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPickDate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Schema";
            Load += FormPickDate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Label label1;
        private RadioButton radioButton8to9;
        private RadioButton radioButton9to10;
        private RadioButton radioButton10to11;
        private RadioButton radioButton11to12;
        private RadioButton radioButton12to13;
        private RadioButton radioButton14to15;
        private RadioButton radioButton15to16;
        private RadioButton radioButton16to17;
        private Button buttonPick;
        private Button buttonCancel;
    }
}