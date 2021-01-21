
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
            this.comboBoxAutoID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelDatumOd = new System.Windows.Forms.Label();
            this.labelDatumDo = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRevBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRezervacija
            // 
            this.listBoxRezervacija.FormattingEnabled = true;
            this.listBoxRezervacija.Location = new System.Drawing.Point(345, 59);
            this.listBoxRezervacija.Name = "listBoxRezervacija";
            this.listBoxRezervacija.Size = new System.Drawing.Size(438, 277);
            this.listBoxRezervacija.TabIndex = 0;
            // 
            // buttonSaveReserve
            // 
            this.buttonSaveReserve.Location = new System.Drawing.Point(132, 299);
            this.buttonSaveReserve.Name = "buttonSaveReserve";
            this.buttonSaveReserve.Size = new System.Drawing.Size(77, 37);
            this.buttonSaveReserve.TabIndex = 1;
            this.buttonSaveReserve.Text = "Sacuvaj";
            this.buttonSaveReserve.UseVisualStyleBackColor = true;
            this.buttonSaveReserve.Click += new System.EventHandler(this.buttonSaveReserve_Click);
            // 
            // labelUernamePick
            // 
            this.labelUernamePick.AutoSize = true;
            this.labelUernamePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUernamePick.ForeColor = System.Drawing.Color.Cyan;
            this.labelUernamePick.Location = new System.Drawing.Point(17, 66);
            this.labelUernamePick.Name = "labelUernamePick";
            this.labelUernamePick.Size = new System.Drawing.Size(106, 17);
            this.labelUernamePick.TabIndex = 2;
            this.labelUernamePick.Text = "JMBG korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(53, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Automobil";
            // 
            // comboBoxAutoID
            // 
            this.comboBoxAutoID.FormattingEnabled = true;
            this.comboBoxAutoID.Location = new System.Drawing.Point(129, 114);
            this.comboBoxAutoID.Name = "comboBoxAutoID";
            this.comboBoxAutoID.Size = new System.Drawing.Size(193, 21);
            this.comboBoxAutoID.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 212);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // labelDatumOd
            // 
            this.labelDatumOd.AutoSize = true;
            this.labelDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumOd.ForeColor = System.Drawing.Color.Cyan;
            this.labelDatumOd.Location = new System.Drawing.Point(25, 165);
            this.labelDatumOd.Name = "labelDatumOd";
            this.labelDatumOd.Size = new System.Drawing.Size(98, 17);
            this.labelDatumOd.TabIndex = 8;
            this.labelDatumOd.Text = "Pocetni datum";
            // 
            // labelDatumDo
            // 
            this.labelDatumDo.AutoSize = true;
            this.labelDatumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumDo.ForeColor = System.Drawing.Color.Cyan;
            this.labelDatumDo.Location = new System.Drawing.Point(25, 213);
            this.labelDatumDo.Name = "labelDatumDo";
            this.labelDatumDo.Size = new System.Drawing.Size(98, 17);
            this.labelDatumDo.TabIndex = 9;
            this.labelDatumDo.Text = "Zavrsni datum";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(247, 299);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(76, 37);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Izlaz";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRevBack
            // 
            this.buttonRevBack.Location = new System.Drawing.Point(20, 299);
            this.buttonRevBack.Name = "buttonRevBack";
            this.buttonRevBack.Size = new System.Drawing.Size(79, 37);
            this.buttonRevBack.TabIndex = 11;
            this.buttonRevBack.Text = "Nazad";
            this.buttonRevBack.UseVisualStyleBackColor = true;
            this.buttonRevBack.Click += new System.EventHandler(this.buttonRevBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(726, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRevBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDatumDo);
            this.Controls.Add(this.labelDatumOd);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxAutoID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUernamePick);
            this.Controls.Add(this.buttonSaveReserve);
            this.Controls.Add(this.listBoxRezervacija);
            this.Name = "FormRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ComboBox comboBoxAutoID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelDatumOd;
        private System.Windows.Forms.Label labelDatumDo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRevBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}