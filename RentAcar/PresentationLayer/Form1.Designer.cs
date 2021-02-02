
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelReserve = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonSaveRez = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DatumOd = new System.Windows.Forms.DateTimePicker();
            this.DatumDo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MarkaOdabir = new System.Windows.Forms.ComboBox();
            this.unesiAuto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ModelOdabir = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBoxReserve = new System.Windows.Forms.ListBox();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentACar200311DataSet = new PresentationLayer.RentACar200311DataSet();
            this.rezervacijeTableAdapter1 = new PresentationLayer.RentACar200311DataSetTableAdapters.RezervacijeTableAdapter();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automobilIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavrsenaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(40, 465);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(272, 24);
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
            this.buttonEdit.Location = new System.Drawing.Point(40, 523);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(272, 24);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Editovanje";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelReserve
            // 
            this.labelReserve.AutoSize = true;
            this.labelReserve.ForeColor = System.Drawing.Color.Cyan;
            this.labelReserve.Location = new System.Drawing.Point(44, 333);
            this.labelReserve.Name = "labelReserve";
            this.labelReserve.Size = new System.Drawing.Size(268, 13);
            this.labelReserve.TabIndex = 5;
            this.labelReserve.Text = "*Za kreiranje nove rezervacije kliknite na zeleno dugme";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.ForeColor = System.Drawing.Color.Cyan;
            this.labelEdit.Location = new System.Drawing.Point(44, 355);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(245, 13);
            this.labelEdit.TabIndex = 7;
            this.labelEdit.Text = "*Za editovanje rezervacije kliknite na plavo dugme";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.ForeColor = System.Drawing.Color.Cyan;
            this.labelDelete.Location = new System.Drawing.Point(44, 379);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(239, 13);
            this.labelDelete.TabIndex = 8;
            this.labelDelete.Text = "*Za brisanje rezervacije kliknite na crveno dugme";
            // 
            // buttonSaveRez
            // 
            this.buttonSaveRez.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSaveRez.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonSaveRez.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSaveRez.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSaveRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveRez.Location = new System.Drawing.Point(40, 410);
            this.buttonSaveRez.Name = "buttonSaveRez";
            this.buttonSaveRez.Size = new System.Drawing.Size(272, 24);
            this.buttonSaveRez.TabIndex = 12;
            this.buttonSaveRez.Text = "Nova rezervacija";
            this.buttonSaveRez.UseVisualStyleBackColor = false;
            this.buttonSaveRez.Click += new System.EventHandler(this.buttonSaveRez_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(44, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marka:";
            // 
            // DatumOd
            // 
            this.DatumOd.CustomFormat = "yyyy-MM-dd";
            this.DatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatumOd.Location = new System.Drawing.Point(47, 218);
            this.DatumOd.Name = "DatumOd";
            this.DatumOd.Size = new System.Drawing.Size(265, 20);
            this.DatumOd.TabIndex = 17;
            // 
            // DatumDo
            // 
            this.DatumDo.CustomFormat = "yyyy-MM-dd";
            this.DatumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatumDo.Location = new System.Drawing.Point(47, 257);
            this.DatumDo.Name = "DatumDo";
            this.DatumDo.Size = new System.Drawing.Size(265, 20);
            this.DatumDo.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(44, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Datum do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(44, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Datum od";
            // 
            // MarkaOdabir
            // 
            this.MarkaOdabir.FormattingEnabled = true;
            this.MarkaOdabir.Location = new System.Drawing.Point(47, 139);
            this.MarkaOdabir.Name = "MarkaOdabir";
            this.MarkaOdabir.Size = new System.Drawing.Size(265, 21);
            this.MarkaOdabir.TabIndex = 22;
            this.MarkaOdabir.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutoID_SelectedIndexChanged);
            // 
            // unesiAuto
            // 
            this.unesiAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.unesiAuto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.unesiAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unesiAuto.ForeColor = System.Drawing.SystemColors.Control;
            this.unesiAuto.Location = new System.Drawing.Point(954, 0);
            this.unesiAuto.Name = "unesiAuto";
            this.unesiAuto.Size = new System.Drawing.Size(125, 23);
            this.unesiAuto.TabIndex = 23;
            this.unesiAuto.Text = "Unos novih automobila";
            this.unesiAuto.UseVisualStyleBackColor = false;
            this.unesiAuto.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1095, -3);
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
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(41, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "RentACar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(655, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Aktualne rezervacije:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(43, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Pretraga:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(47, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Pretraga";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ModelOdabir
            // 
            this.ModelOdabir.FormattingEnabled = true;
            this.ModelOdabir.Location = new System.Drawing.Point(47, 179);
            this.ModelOdabir.Name = "ModelOdabir";
            this.ModelOdabir.Size = new System.Drawing.Size(265, 21);
            this.ModelOdabir.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(44, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Model:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(346, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 35);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            // 
            // Marka
            // 
            this.Marka.DataPropertyName = "Marka";
            this.Marka.HeaderText = "Marka";
            this.Marka.Name = "Marka";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // listBoxReserve
            // 
            this.listBoxReserve.FormattingEnabled = true;
            this.listBoxReserve.Location = new System.Drawing.Point(346, 127);
            this.listBoxReserve.Name = "listBoxReserve";
            this.listBoxReserve.Size = new System.Drawing.Size(800, 420);
            this.listBoxReserve.TabIndex = 9;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Marka";
            this.dataGridViewTextBoxColumn1.HeaderText = "Marka";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marka";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marka";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.klijentIDDataGridViewTextBoxColumn,
            this.automobilIDDataGridViewTextBoxColumn,
            this.datumOdDataGridViewTextBoxColumn,
            this.datumDoDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn1,
            this.korisnikIDDataGridViewTextBoxColumn,
            this.zavrsenaDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.rezervacijeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(346, 127);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(800, 420);
            this.dataGridView2.TabIndex = 35;
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataMember = "Rezervacije";
            this.rezervacijeBindingSource.DataSource = this.rentACar200311DataSet;
            // 
            // rentACar200311DataSet
            // 
            this.rentACar200311DataSet.DataSetName = "RentACar200311DataSet";
            this.rentACar200311DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervacijeTableAdapter1
            // 
            this.rezervacijeTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Width = 50;
            // 
            // klijentIDDataGridViewTextBoxColumn
            // 
            this.klijentIDDataGridViewTextBoxColumn.DataPropertyName = "Klijent ID";
            this.klijentIDDataGridViewTextBoxColumn.HeaderText = "Klijent ID";
            this.klijentIDDataGridViewTextBoxColumn.Name = "klijentIDDataGridViewTextBoxColumn";
            this.klijentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // automobilIDDataGridViewTextBoxColumn
            // 
            this.automobilIDDataGridViewTextBoxColumn.DataPropertyName = "Automobil ID";
            this.automobilIDDataGridViewTextBoxColumn.HeaderText = "Automobil ID";
            this.automobilIDDataGridViewTextBoxColumn.Name = "automobilIDDataGridViewTextBoxColumn";
            this.automobilIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumOdDataGridViewTextBoxColumn
            // 
            this.datumOdDataGridViewTextBoxColumn.DataPropertyName = "Datum od";
            this.datumOdDataGridViewTextBoxColumn.HeaderText = "Datum od";
            this.datumOdDataGridViewTextBoxColumn.Name = "datumOdDataGridViewTextBoxColumn";
            this.datumOdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDoDataGridViewTextBoxColumn
            // 
            this.datumDoDataGridViewTextBoxColumn.DataPropertyName = "Datum do";
            this.datumDoDataGridViewTextBoxColumn.HeaderText = "Datum do";
            this.datumDoDataGridViewTextBoxColumn.Name = "datumDoDataGridViewTextBoxColumn";
            this.datumDoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn1
            // 
            this.napomenaDataGridViewTextBoxColumn1.DataPropertyName = "Napomena";
            this.napomenaDataGridViewTextBoxColumn1.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn1.Name = "napomenaDataGridViewTextBoxColumn1";
            this.napomenaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn1.Width = 120;
            // 
            // korisnikIDDataGridViewTextBoxColumn
            // 
            this.korisnikIDDataGridViewTextBoxColumn.DataPropertyName = "Korisnik ID";
            this.korisnikIDDataGridViewTextBoxColumn.HeaderText = "Korisnik ID";
            this.korisnikIDDataGridViewTextBoxColumn.Name = "korisnikIDDataGridViewTextBoxColumn";
            this.korisnikIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zavrsenaDataGridViewCheckBoxColumn
            // 
            this.zavrsenaDataGridViewCheckBoxColumn.DataPropertyName = "Zavrsena";
            this.zavrsenaDataGridViewCheckBoxColumn.HeaderText = "Zavrsena";
            this.zavrsenaDataGridViewCheckBoxColumn.Name = "zavrsenaDataGridViewCheckBoxColumn";
            this.zavrsenaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1211, 613);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ModelOdabir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.unesiAuto);
            this.Controls.Add(this.MarkaOdabir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatumDo);
            this.Controls.Add(this.DatumOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveRez);
            this.Controls.Add(this.listBoxReserve);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.labelReserve);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentAcar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelReserve;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.Button buttonSaveRez;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatumOd;
        private System.Windows.Forms.DateTimePicker DatumDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MarkaOdabir;
        private System.Windows.Forms.Button unesiAuto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ModelOdabir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.ListBox listBoxReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private RentACar200311DataSet rentACar200311DataSet;
        private RentACar200311DataSetTableAdapters.RezervacijeTableAdapter rezervacijeTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn automobilIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn zavrsenaDataGridViewCheckBoxColumn;
    }
}

