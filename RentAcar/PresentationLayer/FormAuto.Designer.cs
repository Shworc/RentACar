
namespace PresentationLayer
{
    partial class FormAuto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuto));
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSasija = new System.Windows.Forms.TextBox();
            this.txtGodiste = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRevBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registarskiBrojDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSasijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanjeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.automobiliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentACar200311DataSet = new PresentationLayer.RentACar200311DataSet();
            this.automobiliTableAdapter = new PresentationLayer.RentACar200311DataSetTableAdapters.AutomobiliTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Isprazni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.Location = new System.Drawing.Point(149, 227);
            this.listBoxAuto.Name = "listBoxAuto";
            this.listBoxAuto.Size = new System.Drawing.Size(622, 290);
            this.listBoxAuto.TabIndex = 0;
            this.listBoxAuto.SelectedIndexChanged += new System.EventHandler(this.listBoxAuto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model:";
            // 
            // txtMarka
            // 
            this.txtMarka.ForeColor = System.Drawing.SystemColors.Control;
            this.txtMarka.Location = new System.Drawing.Point(28, 39);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(115, 20);
            this.txtMarka.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(27, 78);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(115, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(166, 39);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(115, 20);
            this.txtReg.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(162, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Registarski broj:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(477, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Obrisi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(163, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Broj sasije:";
            // 
            // txtSasija
            // 
            this.txtSasija.Location = new System.Drawing.Point(166, 78);
            this.txtSasija.Name = "txtSasija";
            this.txtSasija.Size = new System.Drawing.Size(115, 20);
            this.txtSasija.TabIndex = 14;
            // 
            // txtGodiste
            // 
            this.txtGodiste.Location = new System.Drawing.Point(302, 39);
            this.txtGodiste.Name = "txtGodiste";
            this.txtGodiste.Size = new System.Drawing.Size(115, 20);
            this.txtGodiste.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(301, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Godiste:";
            // 
            // txtBoja
            // 
            this.txtBoja.Location = new System.Drawing.Point(302, 78);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(115, 20);
            this.txtBoja.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(299, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Boja:";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Lime;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(1050, -2);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 30);
            this.buttonExit.TabIndex = 26;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonRevBack
            // 
            this.buttonRevBack.BackColor = System.Drawing.Color.LightPink;
            this.buttonRevBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRevBack.Location = new System.Drawing.Point(25, 554);
            this.buttonRevBack.Name = "buttonRevBack";
            this.buttonRevBack.Size = new System.Drawing.Size(101, 37);
            this.buttonRevBack.TabIndex = 27;
            this.buttonRevBack.Text = "Nazad";
            this.buttonRevBack.UseVisualStyleBackColor = false;
            this.buttonRevBack.Click += new System.EventHandler(this.buttonRevBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.bojaDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.godisteDataGridViewTextBoxColumn,
            this.registarskiBrojDataGridViewTextBoxColumn,
            this.brojSasijeDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.stanjeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.automobiliBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(27, 123);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1091, 413);
            this.dataGridView1.TabIndex = 34;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.iDDataGridViewTextBoxColumn.Width = 43;
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
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "Tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godisteDataGridViewTextBoxColumn
            // 
            this.godisteDataGridViewTextBoxColumn.DataPropertyName = "Godiste";
            this.godisteDataGridViewTextBoxColumn.HeaderText = "Godiste";
            this.godisteDataGridViewTextBoxColumn.Name = "godisteDataGridViewTextBoxColumn";
            this.godisteDataGridViewTextBoxColumn.ReadOnly = true;
            this.godisteDataGridViewTextBoxColumn.Width = 45;
            // 
            // registarskiBrojDataGridViewTextBoxColumn
            // 
            this.registarskiBrojDataGridViewTextBoxColumn.DataPropertyName = "Registarski broj";
            this.registarskiBrojDataGridViewTextBoxColumn.HeaderText = "Registarski broj";
            this.registarskiBrojDataGridViewTextBoxColumn.Name = "registarskiBrojDataGridViewTextBoxColumn";
            this.registarskiBrojDataGridViewTextBoxColumn.ReadOnly = true;
            this.registarskiBrojDataGridViewTextBoxColumn.Width = 120;
            // 
            // brojSasijeDataGridViewTextBoxColumn
            // 
            this.brojSasijeDataGridViewTextBoxColumn.DataPropertyName = "Broj sasije";
            this.brojSasijeDataGridViewTextBoxColumn.HeaderText = "Broj sasije";
            this.brojSasijeDataGridViewTextBoxColumn.Name = "brojSasijeDataGridViewTextBoxColumn";
            this.brojSasijeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "Napomena";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.napomenaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.Width = 260;
            // 
            // stanjeDataGridViewCheckBoxColumn
            // 
            this.stanjeDataGridViewCheckBoxColumn.DataPropertyName = "Stanje";
            this.stanjeDataGridViewCheckBoxColumn.HeaderText = "Stanje";
            this.stanjeDataGridViewCheckBoxColumn.Name = "stanjeDataGridViewCheckBoxColumn";
            this.stanjeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.stanjeDataGridViewCheckBoxColumn.Width = 80;
            // 
            // automobiliBindingSource
            // 
            this.automobiliBindingSource.DataMember = "Automobili";
            this.automobiliBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.rentACar200311DataSet;
            this.bindingSource1.Position = 0;
            // 
            // rentACar200311DataSet
            // 
            this.rentACar200311DataSet.DataSetName = "RentACar200311DataSet";
            this.rentACar200311DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // automobiliTableAdapter
            // 
            this.automobiliTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1017, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 37);
            this.button3.TabIndex = 35;
            this.button3.Text = "Unesi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(450, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 21);
            this.button4.TabIndex = 36;
            this.button4.Text = "Pretrazi";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Lime;
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LogOut.Location = new System.Drawing.Point(966, -2);
            this.LogOut.Margin = new System.Windows.Forms.Padding(0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(72, 30);
            this.LogOut.TabIndex = 38;
            this.LogOut.Text = "Izloguj se";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(931, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 156);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(1008, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "SoftDogo";
            // 
            // Isprazni
            // 
            this.Isprazni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Isprazni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Isprazni.Location = new System.Drawing.Point(450, 39);
            this.Isprazni.Name = "Isprazni";
            this.Isprazni.Size = new System.Drawing.Size(101, 21);
            this.Isprazni.TabIndex = 41;
            this.Isprazni.Text = "Isprazni";
            this.Isprazni.UseVisualStyleBackColor = false;
            this.Isprazni.Click += new System.EventHandler(this.Isprazni_Click);
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1151, 610);
            this.Controls.Add(this.Isprazni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonRevBack);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGodiste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSasija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAuto";
            this.Load += new System.EventHandler(this.FormAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobiliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentACar200311DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSasija;
        private System.Windows.Forms.TextBox txtGodiste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRevBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RentACar200311DataSet rentACar200311DataSet;
        private System.Windows.Forms.BindingSource automobiliBindingSource;
        private RentACar200311DataSetTableAdapters.AutomobiliTableAdapter automobiliTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Isprazni;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registarskiBrojDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSasijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stanjeDataGridViewCheckBoxColumn;
    }
}