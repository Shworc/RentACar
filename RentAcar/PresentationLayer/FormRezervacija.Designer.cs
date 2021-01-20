
namespace PresentationLayer
{
    partial class FormRezervacija
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
            this.listBoxRezervacija = new System.Windows.Forms.ListBox();
            this.buttonSaveReserve = new System.Windows.Forms.Button();
            this.labelUernamePick = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxZakupacID = new System.Windows.Forms.ComboBox();
            this.comboBoxAutoID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelDatumOd = new System.Windows.Forms.Label();
            this.labelDatumDo = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRevBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRezervacija
            // 
            this.listBoxRezervacija.FormattingEnabled = true;
            this.listBoxRezervacija.Location = new System.Drawing.Point(333, 48);
            this.listBoxRezervacija.Name = "listBoxRezervacija";
            this.listBoxRezervacija.Size = new System.Drawing.Size(438, 212);
            this.listBoxRezervacija.TabIndex = 0;
            // 
            // buttonSaveReserve
            // 
            this.buttonSaveReserve.Location = new System.Drawing.Point(31, 280);
            this.buttonSaveReserve.Name = "buttonSaveReserve";
            this.buttonSaveReserve.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveReserve.TabIndex = 1;
            this.buttonSaveReserve.Text = "Sacuvaj";
            this.buttonSaveReserve.UseVisualStyleBackColor = true;
            this.buttonSaveReserve.Click += new System.EventHandler(this.buttonSaveReserve_Click);
            // 
            // labelUernamePick
            // 
            this.labelUernamePick.AutoSize = true;
            this.labelUernamePick.Location = new System.Drawing.Point(28, 51);
            this.labelUernamePick.Name = "labelUernamePick";
            this.labelUernamePick.Size = new System.Drawing.Size(69, 13);
            this.labelUernamePick.TabIndex = 2;
            this.labelUernamePick.Text = "Ime korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Automobil";
            // 
            // comboBoxZakupacID
            // 
            this.comboBoxZakupacID.FormattingEnabled = true;
            this.comboBoxZakupacID.Items.AddRange(new object[] {
            "{0}",
            "{1}"});
            this.comboBoxZakupacID.Location = new System.Drawing.Point(108, 48);
            this.comboBoxZakupacID.Name = "comboBoxZakupacID";
            this.comboBoxZakupacID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxZakupacID.TabIndex = 4;
            this.comboBoxZakupacID.SelectedIndexChanged += new System.EventHandler(this.comboBoxZakupacID_SelectedIndexChanged);
            // 
            // comboBoxAutoID
            // 
            this.comboBoxAutoID.FormattingEnabled = true;
            this.comboBoxAutoID.Location = new System.Drawing.Point(108, 99);
            this.comboBoxAutoID.Name = "comboBoxAutoID";
            this.comboBoxAutoID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAutoID.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(108, 226);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // labelDatumOd
            // 
            this.labelDatumOd.AutoSize = true;
            this.labelDatumOd.Location = new System.Drawing.Point(28, 169);
            this.labelDatumOd.Name = "labelDatumOd";
            this.labelDatumOd.Size = new System.Drawing.Size(75, 13);
            this.labelDatumOd.TabIndex = 8;
            this.labelDatumOd.Text = "Pocetni datum";
            // 
            // labelDatumDo
            // 
            this.labelDatumDo.AutoSize = true;
            this.labelDatumDo.Location = new System.Drawing.Point(28, 232);
            this.labelDatumDo.Name = "labelDatumDo";
            this.labelDatumDo.Size = new System.Drawing.Size(74, 13);
            this.labelDatumDo.TabIndex = 9;
            this.labelDatumDo.Text = "Zavrsni datum";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(696, 364);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Izlaz";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRevBack
            // 
            this.buttonRevBack.Location = new System.Drawing.Point(28, 364);
            this.buttonRevBack.Name = "buttonRevBack";
            this.buttonRevBack.Size = new System.Drawing.Size(75, 23);
            this.buttonRevBack.TabIndex = 11;
            this.buttonRevBack.Text = "Nazad";
            this.buttonRevBack.UseVisualStyleBackColor = true;
            this.buttonRevBack.Click += new System.EventHandler(this.buttonRevBack_Click);
            // 
            // FormRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRevBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDatumDo);
            this.Controls.Add(this.labelDatumOd);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxAutoID);
            this.Controls.Add(this.comboBoxZakupacID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUernamePick);
            this.Controls.Add(this.buttonSaveReserve);
            this.Controls.Add(this.listBoxRezervacija);
            this.Name = "FormRezervacija";
            this.Text = "FormRezervacija";
            this.Load += new System.EventHandler(this.FormRezervacija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRezervacija;
        private System.Windows.Forms.Button buttonSaveReserve;
        private System.Windows.Forms.Label labelUernamePick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxZakupacID;
        private System.Windows.Forms.ComboBox comboBoxAutoID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelDatumOd;
        private System.Windows.Forms.Label labelDatumDo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRevBack;
    }
}