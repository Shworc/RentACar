
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervacija));
            this.buttonSaveReserve = new System.Windows.Forms.Button();
            this.JMBGTEXT = new System.Windows.Forms.Label();
            this.ImeText = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PocetniDatumUnos = new System.Windows.Forms.DateTimePicker();
            this.labelDatumOd = new System.Windows.Forms.Label();
            this.ZavrsniDatumUnos = new System.Windows.Forms.Label();
            this.buttonRevBack = new System.Windows.Forms.Button();
            this.JMBGUNOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdresaText = new System.Windows.Forms.Label();
            this.GradText = new System.Windows.Forms.Label();
            this.MobilniText = new System.Windows.Forms.Label();
            this.ImeUnos = new System.Windows.Forms.TextBox();
            this.PrezimeUnos = new System.Windows.Forms.TextBox();
            this.AdresaUnos = new System.Windows.Forms.TextBox();
            this.GradUnos = new System.Windows.Forms.TextBox();
            this.MobilniUnos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MarkaOdabir = new System.Windows.Forms.ComboBox();
            this.ModelOdabir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.OdabranAutoText = new System.Windows.Forms.Label();
            this.OdabranAutoIspis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rentACar200311DataSet = new PresentationLayer.RentACar200311DataSet();
            this.rentACar200311DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(890, 419);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // PocetniDatumUnos
            // 
            this.PocetniDatumUnos.CustomFormat = "yyyy-MM-dd";
            this.PocetniDatumUnos.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PocetniDatumUnos.Location = new System.Drawing.Point(889, 376);
            this.PocetniDatumUnos.Name = "PocetniDatumUnos";
            this.PocetniDatumUnos.Size = new System.Drawing.Size(193, 20);
            this.PocetniDatumUnos.TabIndex = 7;
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
            // ZavrsniDatumUnos
            // 
            this.ZavrsniDatumUnos.AutoSize = true;
            this.ZavrsniDatumUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZavrsniDatumUnos.ForeColor = System.Drawing.Color.White;
            this.ZavrsniDatumUnos.Location = new System.Drawing.Point(887, 399);
            this.ZavrsniDatumUnos.Name = "ZavrsniDatumUnos";
            this.ZavrsniDatumUnos.Size = new System.Drawing.Size(98, 17);
            this.ZavrsniDatumUnos.TabIndex = 9;
            this.ZavrsniDatumUnos.Text = "Zavrsni datum";
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
            // JMBGUNOS
            // 
            this.JMBGUNOS.Location = new System.Drawing.Point(889, 333);
            this.JMBGUNOS.Name = "JMBGUNOS";
            this.JMBGUNOS.Size = new System.Drawing.Size(194, 20);
            this.JMBGUNOS.TabIndex = 12;
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
            // ImeUnos
            // 
            this.ImeUnos.Location = new System.Drawing.Point(889, 118);
            this.ImeUnos.Name = "ImeUnos";
            this.ImeUnos.Size = new System.Drawing.Size(194, 20);
            this.ImeUnos.TabIndex = 30;
            // 
            // PrezimeUnos
            // 
            this.PrezimeUnos.Location = new System.Drawing.Point(889, 161);
            this.PrezimeUnos.Name = "PrezimeUnos";
            this.PrezimeUnos.Size = new System.Drawing.Size(194, 20);
            this.PrezimeUnos.TabIndex = 31;
            // 
            // AdresaUnos
            // 
            this.AdresaUnos.Location = new System.Drawing.Point(889, 204);
            this.AdresaUnos.Name = "AdresaUnos";
            this.AdresaUnos.Size = new System.Drawing.Size(194, 20);
            this.AdresaUnos.TabIndex = 32;
            // 
            // GradUnos
            // 
            this.GradUnos.Location = new System.Drawing.Point(889, 247);
            this.GradUnos.Name = "GradUnos";
            this.GradUnos.Size = new System.Drawing.Size(194, 20);
            this.GradUnos.TabIndex = 33;
            // 
            // MobilniUnos
            // 
            this.MobilniUnos.Location = new System.Drawing.Point(889, 290);
            this.MobilniUnos.Name = "MobilniUnos";
            this.MobilniUnos.Size = new System.Drawing.Size(194, 20);
            this.MobilniUnos.TabIndex = 34;
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
            // MarkaOdabir
            // 
            this.MarkaOdabir.FormattingEnabled = true;
            this.MarkaOdabir.Location = new System.Drawing.Point(24, 117);
            this.MarkaOdabir.Name = "MarkaOdabir";
            this.MarkaOdabir.Size = new System.Drawing.Size(168, 21);
            this.MarkaOdabir.TabIndex = 38;
            // 
            // ModelOdabir
            // 
            this.ModelOdabir.FormattingEnabled = true;
            this.ModelOdabir.Location = new System.Drawing.Point(24, 161);
            this.ModelOdabir.Name = "ModelOdabir";
            this.ModelOdabir.Size = new System.Drawing.Size(168, 21);
            this.ModelOdabir.TabIndex = 39;
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
            this.button2.Location = new System.Drawing.Point(24, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 37);
            this.button2.TabIndex = 44;
            this.button2.Text = "Pretrazi";
            this.button2.UseVisualStyleBackColor = true;
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
            // OdabranAutoIspis
            // 
            this.OdabranAutoIspis.Location = new System.Drawing.Point(26, 373);
            this.OdabranAutoIspis.Name = "OdabranAutoIspis";
            this.OdabranAutoIspis.Size = new System.Drawing.Size(166, 20);
            this.OdabranAutoIspis.TabIndex = 46;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 419);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 48;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(205, 1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(672, 574);
            this.dataGridView1.TabIndex = 53;
            // 
            // FormRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1126, 571);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OdabranAutoIspis);
            this.Controls.Add(this.OdabranAutoText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelOdabir);
            this.Controls.Add(this.MarkaOdabir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MobilniUnos);
            this.Controls.Add(this.GradUnos);
            this.Controls.Add(this.AdresaUnos);
            this.Controls.Add(this.PrezimeUnos);
            this.Controls.Add(this.ImeUnos);
            this.Controls.Add(this.MobilniText);
            this.Controls.Add(this.GradText);
            this.Controls.Add(this.AdresaText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JMBGUNOS);
            this.Controls.Add(this.buttonRevBack);
            this.Controls.Add(this.ZavrsniDatumUnos);
            this.Controls.Add(this.labelDatumOd);
            this.Controls.Add(this.PocetniDatumUnos);
            this.Controls.Add(this.dateTimePicker1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveReserve;
        private System.Windows.Forms.Label JMBGTEXT;
        private System.Windows.Forms.Label ImeText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker PocetniDatumUnos;
        private System.Windows.Forms.Label labelDatumOd;
        private System.Windows.Forms.Label ZavrsniDatumUnos;
        private System.Windows.Forms.Button buttonRevBack;
        private System.Windows.Forms.TextBox JMBGUNOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AdresaText;
        private System.Windows.Forms.Label GradText;
        private System.Windows.Forms.Label MobilniText;
        private System.Windows.Forms.TextBox ImeUnos;
        private System.Windows.Forms.TextBox PrezimeUnos;
        private System.Windows.Forms.TextBox AdresaUnos;
        private System.Windows.Forms.TextBox GradUnos;
        private System.Windows.Forms.TextBox MobilniUnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox MarkaOdabir;
        private System.Windows.Forms.ComboBox ModelOdabir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label OdabranAutoText;
        private System.Windows.Forms.TextBox OdabranAutoIspis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private RentACar200311DataSet rentACar200311DataSet;
        private System.Windows.Forms.BindingSource rentACar200311DataSetBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}