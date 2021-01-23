
namespace PresentationLayer
{
    partial class Form1
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
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelReserve = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.listBoxReserve = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSaveRez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxZakupacID = new System.Windows.Forms.ComboBox();
            this.comboBoxAutoID = new System.Windows.Forms.ComboBox();
            this.unesiAuto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReserve
            // 
            this.buttonReserve.BackColor = System.Drawing.Color.Transparent;
            this.buttonReserve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReserve.Location = new System.Drawing.Point(268, 393);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(112, 23);
            this.buttonReserve.TabIndex = 0;
            this.buttonReserve.Text = "Rezervacija";
            this.buttonReserve.UseVisualStyleBackColor = false;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(233, 269);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 24);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Brisanje";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Blue;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(140, 269);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 24);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Editovanje";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelReserve
            // 
            this.labelReserve.AutoSize = true;
            this.labelReserve.Location = new System.Drawing.Point(44, 307);
            this.labelReserve.Name = "labelReserve";
            this.labelReserve.Size = new System.Drawing.Size(225, 13);
            this.labelReserve.TabIndex = 5;
            this.labelReserve.Text = "*Za novu rezervaciju kliknite na zeleno dugme";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(44, 331);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(192, 13);
            this.labelEdit.TabIndex = 7;
            this.labelEdit.Text = "*Za Editovanje kliknite na plavo dugme";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(44, 355);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(185, 13);
            this.labelDelete.TabIndex = 8;
            this.labelDelete.Text = "*Za brisanje kliknite na crveno dugme";
            // 
            // listBoxReserve
            // 
            this.listBoxReserve.FormattingEnabled = true;
            this.listBoxReserve.Location = new System.Drawing.Point(425, 91);
            this.listBoxReserve.Name = "listBoxReserve";
            this.listBoxReserve.Size = new System.Drawing.Size(363, 277);
            this.listBoxReserve.TabIndex = 9;
            // 
            // buttonBack
            // 
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(40, 393);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Nazad";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonSaveRez
            // 
            this.buttonSaveRez.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSaveRez.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonSaveRez.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSaveRez.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSaveRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveRez.Location = new System.Drawing.Point(47, 269);
            this.buttonSaveRez.Name = "buttonSaveRez";
            this.buttonSaveRez.Size = new System.Drawing.Size(75, 24);
            this.buttonSaveRez.TabIndex = 12;
            this.buttonSaveRez.Text = "Snimi";
            this.buttonSaveRez.UseVisualStyleBackColor = false;
            this.buttonSaveRez.Click += new System.EventHandler(this.buttonSaveRez_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Izaberite korisnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Izaberite automobil";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(47, 226);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Datum do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Datum od";
            // 
            // comboBoxZakupacID
            // 
            this.comboBoxZakupacID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZakupacID.FormattingEnabled = true;
            this.comboBoxZakupacID.Location = new System.Drawing.Point(47, 103);
            this.comboBoxZakupacID.Name = "comboBoxZakupacID";
            this.comboBoxZakupacID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxZakupacID.TabIndex = 21;
            this.comboBoxZakupacID.SelectedIndexChanged += new System.EventHandler(this.comboBoxZakupacID_SelectedIndexChanged);
            // 
            // comboBoxAutoID
            // 
            this.comboBoxAutoID.FormattingEnabled = true;
            this.comboBoxAutoID.Location = new System.Drawing.Point(47, 143);
            this.comboBoxAutoID.Name = "comboBoxAutoID";
            this.comboBoxAutoID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAutoID.TabIndex = 22;
            this.comboBoxAutoID.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutoID_SelectedIndexChanged);
            // 
            // unesiAuto
            // 
            this.unesiAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unesiAuto.Location = new System.Drawing.Point(425, 393);
            this.unesiAuto.Name = "unesiAuto";
            this.unesiAuto.Size = new System.Drawing.Size(112, 23);
            this.unesiAuto.TabIndex = 23;
            this.unesiAuto.Text = "Unesi Auto";
            this.unesiAuto.UseVisualStyleBackColor = true;
            this.unesiAuto.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(706, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(34, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "RentACar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unesiAuto);
            this.Controls.Add(this.comboBoxAutoID);
            this.Controls.Add(this.comboBoxZakupacID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveRez);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxReserve);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.labelReserve);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonReserve);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "RentAcar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelReserve;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.ListBox listBoxReserve;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSaveRez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxZakupacID;
        private System.Windows.Forms.ComboBox comboBoxAutoID;
        private System.Windows.Forms.Button unesiAuto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

