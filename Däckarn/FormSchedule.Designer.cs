namespace Däckarn
{
    partial class FormSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            listViewBookings = new ListView();
            columnDate = new ColumnHeader();
            columnDone = new ColumnHeader();
            columnName = new ColumnHeader();
            columnPremium = new ColumnHeader();
            columnRegNr = new ColumnHeader();
            columnCar = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listViewBookings
            // 
            listViewBookings.Columns.AddRange(new ColumnHeader[] { columnDate, columnDone, columnName, columnPremium, columnRegNr, columnCar });
            listViewBookings.FullRowSelect = true;
            listViewBookings.GridLines = true;
            listViewBookings.Location = new Point(12, 12);
            listViewBookings.MultiSelect = false;
            listViewBookings.Name = "listViewBookings";
            listViewBookings.Size = new Size(794, 507);
            listViewBookings.TabIndex = 2;
            listViewBookings.UseCompatibleStateImageBehavior = false;
            listViewBookings.View = View.Details;
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
            // button1
            // 
            button1.Location = new Point(372, 527);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 562);
            Controls.Add(button1);
            Controls.Add(listViewBookings);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSchedule";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Schema";
            Load += FormSchedule_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewBookings;
        private ColumnHeader columnDate;
        private ColumnHeader columnDone;
        private ColumnHeader columnName;
        private ColumnHeader columnPremium;
        private ColumnHeader columnRegNr;
        private ColumnHeader columnCar;
        private Button button1;
    }
}