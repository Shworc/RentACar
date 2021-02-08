
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervacija));
            this.buttonSaveReserve = new System.Windows.Forms.Button();
            this.JMBGTEXT = new System.Windows.Forms.Label();
            this.ImeText = new System.Windows.Forms.Label();
            this.DatumDo = new System.Windows.Forms.DateTimePicker();
            this.DatumOd = new System.Windows.Forms.DateTimePicker();
            this.labelDatumOd = new System.Windows.Forms.Label();
            this.ZavrsnidatumUnos = new System.Windows.Forms.Label();
            this.buttonRevBack = new System.Windows.Forms.Button();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdresaText = new System.Windows.Forms.Label();
            this.GradText = new System.Windows.Forms.Label();
            this.MobilniText = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtMobilni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMarkaOdabir = new System.Windows.Forms.ComboBox();
            this.cmbModelOdabir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.OdabranAutoText = new System.Windows.Forms.Label();
            this.txtOdabranAuto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRegistarskiBroj = new System.Windows.Forms.TextBox();
            this.rentACar200311DataSet = new PresentationLayer.RentACar200311DataSet();
            this.rentACar200311DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.automobiliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.automobiliTableAdapter = new PresentationLayer.RentACar200311DataSetTableAdapters.AutomobiliTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registarskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveReserve
            // 
            this.buttonSaveReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSaveReserve.FlatAppearance.BorderSize = 0;
            this.buttonSaveReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveReserve.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveReserve.Location = new System.Drawing.Point(889, 490);
            this.buttonSaveReserve.Name = "buttonSaveReserve";
            this.buttonSaveReserve.Size = new System.Drawing.Size(195, 52);
            this.buttonSaveReserve.TabIndex = 1;
            this.buttonSaveReserve.Text = "Rezervisi";
            this.buttonSaveReserve.UseVisualStyleBackColor = false;
            this.buttonSaveReserve.Click += new System.EventHandler(this.buttonSaveReserve_Click);
            // 
            // JMBGTEXT
            // 
            this.JMBGTEXT.AutoSize = true;
            this.JMBGTEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMBGTEXT.ForeColor = System.Drawing.Color.White;
            this.JMBGTEXT.Location = new System.Drawing.Point(886, 313);
            this.JMBGTEXT.Name = "JMBGTEXT";
            this.JMBGTEXT.Size = new System.Drawing.Size(110, 17);
            this.JMBGTEXT.TabIndex = 2;
            this.JMBGTEXT.Text = "JMBG korisnika:";
            // 
            // ImeText
            // 
            this.ImeText.AutoSize = true;
            this.ImeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeText.ForeColor = System.Drawing.Color.White;
            this.ImeText.Location = new System.Drawing.Point(886, 98);
            this.ImeText.Name = "ImeText";
            this.ImeText.Size = new System.Drawing.Size(34, 17);
            this.ImeText.TabIndex = 3;
            this.ImeText.Text = "Ime:";
            // 
            // DatumDo
            // 
            this.DatumDo.CalendarForeColor = System.Drawing.Color.Black;
            this.DatumDo.CustomFormat = "yyyy-MM-dd";
            this.DatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatumDo.Location = new System.Drawing.Point(890, 419);
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.Size = new System.Drawing.Size(194, 20);
            this.DatumDo.TabIndex = 6;
            // 
            // DatumOd
            // 
            this.DatumOd.CustomFormat = "yyyy-MM-dd";
            this.DatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatumOd.Location = new System.Drawing.Point(889, 376);
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.Size = new System.Drawing.Size(193, 20);
            this.DatumOd.TabIndex = 7;
            // 
            // labelDatumOd
            // 
            this.labelDatumOd.AutoSize = true;
            this.labelDatumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumOd.ForeColor = System.Drawing.Color.White;
            this.labelDatumOd.Location = new System.Drawing.Point(887, 356);
            this.labelDatumOd.Name = "labelDatumOd";
            this.labelDatumOd.Size = new System.Drawing.Size(98, 17);
            this.labelDatumOd.TabIndex = 8;
            this.labelDatumOd.Text = "Pocetni datum";
            // 
            // ZavrsnidatumUnos
            // 
            this.ZavrsnidatumUnos.AutoSize = true;
            this.ZavrsnidatumUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZavrsnidatumUnos.ForeColor = System.Drawing.Color.White;
            this.ZavrsnidatumUnos.Location = new System.Drawing.Point(887, 399);
            this.ZavrsnidatumUnos.Name = "ZavrsnidatumUnos";
            this.ZavrsnidatumUnos.Size = new System.Drawing.Size(98, 17);
            this.ZavrsnidatumUnos.TabIndex = 9;
            this.ZavrsnidatumUnos.Text = "Zavrsni datum";
            // 
            // buttonRevBack
            // 
            this.buttonRevBack.BackColor = System.Drawing.Color.LightPink;
            this.buttonRevBack.FlatAppearance.BorderSize = 0;
            this.buttonRevBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRevBack.ForeColor = System.Drawing.Color.Black;
            this.buttonRevBack.Location = new System.Drawing.Point(26, 490);
            this.buttonRevBack.Name = "buttonRevBack";
            this.buttonRevBack.Size = new System.Drawing.Size(166, 52);
            this.buttonRevBack.TabIndex = 11;
            this.buttonRevBack.Text = "Nazad";
            this.buttonRevBack.UseVisualStyleBackColor = false;
            this.buttonRevBack.Click += new System.EventHandler(this.buttonRevBack_Click);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(889, 333);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(194, 20);
            this.txtJMBG.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(886, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Prezime:";
            // 
            // AdresaText
            // 
            this.AdresaText.AutoSize = true;
            this.AdresaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresaText.ForeColor = System.Drawing.Color.White;
            this.AdresaText.Location = new System.Drawing.Point(886, 184);
            this.AdresaText.Name = "AdresaText";
            this.AdresaText.Size = new System.Drawing.Size(57, 17);
            this.AdresaText.TabIndex = 27;
            this.AdresaText.Text = "Adresa:";
            // 
            // GradText
            // 
            this.GradText.AutoSize = true;
            this.GradText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradText.ForeColor = System.Drawing.Color.White;
            this.GradText.Location = new System.Drawing.Point(886, 227);
            this.GradText.Name = "GradText";
            this.GradText.Size = new System.Drawing.Size(44, 17);
            this.GradText.TabIndex = 28;
            this.GradText.Text = "Grad:";
            // 
            // MobilniText
            // 
            this.MobilniText.AutoSize = true;
            this.MobilniText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobilniText.ForeColor = System.Drawing.Color.White;
            this.MobilniText.Location = new System.Drawing.Point(886, 270);
            this.MobilniText.Name = "MobilniText";
            this.MobilniText.Size = new System.Drawing.Size(84, 17);
            this.MobilniText.TabIndex = 29;
            this.MobilniText.Text = "Mobilni broj:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(889, 118);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(194, 20);
            this.txtIme.TabIndex = 30;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(889, 161);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(194, 20);
            this.txtPrezime.TabIndex = 31;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(889, 204);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(194, 20);
            this.txtAdresa.TabIndex = 32;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(889, 247);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(194, 20);
            this.txtGrad.TabIndex = 33;
            // 
            // txtMobilni
            // 
            this.txtMobilni.Location = new System.Drawing.Point(889, 290);
            this.txtMobilni.Name = "txtMobilni";
            this.txtMobilni.Size = new System.Drawing.Size(194, 20);
            this.txtMobilni.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Dostupni automobili:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "*izabrati ponudjeni";
            // 
            // cmbMarkaOdabir
            // 
            this.cmbMarkaOdabir.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMarkaOdabir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMarkaOdabir.FormattingEnabled = true;
            this.cmbMarkaOdabir.Location = new System.Drawing.Point(24, 117);
            this.cmbMarkaOdabir.Name = "cmbMarkaOdabir";
            this.cmbMarkaOdabir.Size = new System.Drawing.Size(168, 21);
            this.cmbMarkaOdabir.TabIndex = 38;
            this.cmbMarkaOdabir.TextChanged += new System.EventHandler(this.ComboMarka);
            // 
            // cmbModelOdabir
            // 
            this.cmbModelOdabir.FormattingEnabled = true;
            this.cmbModelOdabir.Location = new System.Drawing.Point(24, 161);
            this.cmbModelOdabir.Name = "cmbModelOdabir";
            this.cmbModelOdabir.Size = new System.Drawing.Size(168, 21);
            this.cmbModelOdabir.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Marka automobila:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Model automobila:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(902, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Unos podataka o klijentu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Pretraga automobila";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(24, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 29);
            this.button2.TabIndex = 44;
            this.button2.Text = "Pretrazi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OdabranAutoText
            // 
            this.OdabranAutoText.AutoSize = true;
            this.OdabranAutoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdabranAutoText.ForeColor = System.Drawing.Color.White;
            this.OdabranAutoText.Location = new System.Drawing.Point(21, 353);
            this.OdabranAutoText.Name = "OdabranAutoText";
            this.OdabranAutoText.Size = new System.Drawing.Size(100, 17);
            this.OdabranAutoText.TabIndex = 45;
            this.OdabranAutoText.Text = "Odabran auto:";
            // 
            // txtOdabranAuto
            // 
            this.txtOdabranAuto.Location = new System.Drawing.Point(26, 373);
            this.txtOdabranAuto.Name = "txtOdabranAuto";
            this.txtOdabranAuto.ReadOnly = true;
            this.txtOdabranAuto.Size = new System.Drawing.Size(166, 20);
            this.txtOdabranAuto.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Registarski broj";
            // 
            // txtRegistarskiBroj
            // 
            this.txtRegistarskiBroj.Location = new System.Drawing.Point(26, 419);
            this.txtRegistarskiBroj.Name = "txtRegistarskiBroj";
            this.txtRegistarskiBroj.ReadOnly = true;
            this.txtRegistarskiBroj.Size = new System.Drawing.Size(166, 20);
            this.txtRegistarskiBroj.TabIndex = 48;
            // 
            // rentACar200311DataSet
            // 
            this.rentACar200311DataSet.DataSetName = "RentACar200311DataSet";
            this.rentACar200311DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentACar200311DataSetBindingSource
            // 
            this.rentACar200311DataSetBindingSource.DataSource = this.rentACar200311DataSet;
            this.rentACar200311DataSetBindingSource.Position = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(1089, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Slika automobila";
            this.label8.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1089, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 177);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.Location = new System.Drawing.Point(900, -2);
            this.LogOut.Margin = new System.Windows.Forms.Padding(0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(72, 30);
            this.LogOut.TabIndex = 52;
            this.LogOut.Text = "Izloguj se";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(993, -2);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 30);
            this.buttonExit.TabIndex = 51;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.godisteDataGridViewTextBoxColumn,
            this.registarskiBrojDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.automobiliBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(205, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(672, 571);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnosSelektovanogUPolja);
            // 
            // automobiliBindingSource
            // 
            this.automobiliBindingSource.DataMember = "Automobili";
            this.automobiliBindingSource.DataSource = this.rentACar200311DataSetBindingSource;
            // 
            // automobiliTableAdapter
            // 
            this.automobiliTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bojaDataGridViewTextBoxColumn
            // 
            this.bojaDataGridViewTextBoxColumn.DataPropertyName = "Boja";
            this.bojaDataGridViewTextBoxColumn.HeaderText = "Boja";
            this.bojaDataGridViewTextBoxColumn.Name = "bojaDataGridViewTextBoxColumn";
            this.bojaDataGridViewTextBoxColumn.ReadOnly = true;
            this.bojaDataGridViewTextBoxColumn.Width = 70;
            // 
            // godisteDataGridViewTextBoxColumn
            // 
            this.godisteDataGridViewTextBoxColumn.DataPropertyName = "Godiste";
            this.godisteDataGridViewTextBoxColumn.HeaderText = "Godiste";
            this.godisteDataGridViewTextBoxColumn.Name = "godisteDataGridViewTextBoxColumn";
            this.godisteDataGridViewTextBoxColumn.ReadOnly = true;
            this.godisteDataGridViewTextBoxColumn.Width = 60;
            // 
            // registarskiBrojDataGridViewTextBoxColumn
            // 
            this.registarskiBrojDataGridViewTextBoxColumn.DataPropertyName = "Registarski broj";
            this.registarskiBrojDataGridViewTextBoxColumn.HeaderText = "Registarski broj";
            this.registarskiBrojDataGridViewTextBoxColumn.Name = "registarskiBrojDataGridViewTextBoxColumn";
            this.registarskiBrojDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.Width = 200;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(24, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 28);
            this.button1.TabIndex = 54;
            this.button1.Text = "Isprazni polja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1126, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRegistarskiBroj);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOdabranAuto);
            this.Controls.Add(this.OdabranAutoText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbModelOdabir);
            this.Controls.Add(this.cmbMarkaOdabir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMobilni);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.MobilniText);
            this.Controls.Add(this.GradText);
            this.Controls.Add(this.AdresaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.buttonRevBack);
            this.Controls.Add(this.ZavrsnidatumUnos);
            this.Controls.Add(this.labelDatumOd);
            this.Controls.Add(this.DatumOd);
            this.Controls.Add(this.DatumDo);
            this.Controls.Add(this.ImeText);
            this.Controls.Add(this.JMBGTEXT);
            this.Controls.Add(this.buttonSaveReserve);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRezervacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRezervacija";
            this.Load += new System.EventHandler(this.FormRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveReserve;
        private System.Windows.Forms.Label JMBGTEXT;
        private System.Windows.Forms.Label ImeText;
        private System.Windows.Forms.DateTimePicker DatumDo;
        private System.Windows.Forms.DateTimePicker DatumOd;
        private System.Windows.Forms.Label labelDatumOd;
        private System.Windows.Forms.Label ZavrsnidatumUnos;
        private System.Windows.Forms.Button buttonRevBack;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdresaText;
        private System.Windows.Forms.Label GradText;
        private System.Windows.Forms.Label MobilniText;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtMobilni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMarkaOdabir;
        private System.Windows.Forms.ComboBox cmbModelOdabir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label OdabranAutoText;
        private System.Windows.Forms.TextBox txtOdabranAuto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRegistarskiBroj;
        private RentACar200311DataSet rentACar200311DataSet;
        private System.Windows.Forms.BindingSource rentACar200311DataSetBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource automobiliBindingSource;
        private RentACar200311DataSetTableAdapters.AutomobiliTableAdapter automobiliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registarskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}