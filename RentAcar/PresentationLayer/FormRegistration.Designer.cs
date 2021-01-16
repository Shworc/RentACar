
namespace PresentationLayer
{
    partial class FormRegistration
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxZakupci = new System.Windows.Forms.ListBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.rentacarDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentacarDBDataSet = new PresentationLayer.RentacarDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(196, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(196, 119);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(73, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(107, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Unesite ime korisnika";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(56, 122);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(124, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Unesite lozinku korisnika";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(208, 182);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Sacuvaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(76, 382);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Nazad";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(616, 382);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Izlaz";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // listBoxZakupci
            // 
            this.listBoxZakupci.FormattingEnabled = true;
            this.listBoxZakupci.Location = new System.Drawing.Point(433, 38);
            this.listBoxZakupci.Name = "listBoxZakupci";
            this.listBoxZakupci.Size = new System.Drawing.Size(279, 186);
            this.listBoxZakupci.TabIndex = 7;
            this.listBoxZakupci.Click += new System.EventHandler(this.listBoxZakupci_Click);
            this.listBoxZakupci.SelectedIndexChanged += new System.EventHandler(this.listBoxZakupci_SelectedIndexChanged);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(433, 240);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Izmeni";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Location = new System.Drawing.Point(637, 240);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 23);
            this.buttonErase.TabIndex = 9;
            this.buttonErase.Text = "Obrisi";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // rentacarDBDataSetBindingSource
            // 
            this.rentacarDBDataSetBindingSource.DataSource = this.rentacarDBDataSet;
            this.rentacarDBDataSetBindingSource.Position = 0;
            // 
            // rentacarDBDataSet
            // 
            this.rentacarDBDataSet.DataSetName = "RentacarDBDataSet";
            this.rentacarDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.listBoxZakupci);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentacarDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxZakupci;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.BindingSource rentacarDBDataSetBindingSource;
        private RentacarDBDataSet rentacarDBDataSet;
    }
}