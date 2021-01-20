
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
            this.listBoxAuto = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAutoMarka = new System.Windows.Forms.TextBox();
            this.textBoxAutoNaziv = new System.Windows.Forms.TextBox();
            this.buttonAutoSave = new System.Windows.Forms.Button();
            this.buttonAutoUpdate = new System.Windows.Forms.Button();
            this.buttonAutoDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBackAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAuto
            // 
            this.listBoxAuto.FormattingEnabled = true;
            this.listBoxAuto.Location = new System.Drawing.Point(406, 66);
            this.listBoxAuto.Name = "listBoxAuto";
            this.listBoxAuto.Size = new System.Drawing.Size(310, 238);
            this.listBoxAuto.TabIndex = 0;
            this.listBoxAuto.SelectedIndexChanged += new System.EventHandler(this.listBoxAuto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite marku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite naziv";
            // 
            // textBoxAutoMarka
            // 
            this.textBoxAutoMarka.Location = new System.Drawing.Point(66, 95);
            this.textBoxAutoMarka.Name = "textBoxAutoMarka";
            this.textBoxAutoMarka.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutoMarka.TabIndex = 3;
            // 
            // textBoxAutoNaziv
            // 
            this.textBoxAutoNaziv.Location = new System.Drawing.Point(66, 160);
            this.textBoxAutoNaziv.Name = "textBoxAutoNaziv";
            this.textBoxAutoNaziv.Size = new System.Drawing.Size(100, 20);
            this.textBoxAutoNaziv.TabIndex = 4;
            // 
            // buttonAutoSave
            // 
            this.buttonAutoSave.Location = new System.Drawing.Point(48, 235);
            this.buttonAutoSave.Name = "buttonAutoSave";
            this.buttonAutoSave.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoSave.TabIndex = 5;
            this.buttonAutoSave.Text = "Snimi";
            this.buttonAutoSave.UseVisualStyleBackColor = true;
            this.buttonAutoSave.Click += new System.EventHandler(this.buttonAutoSave_Click);
            // 
            // buttonAutoUpdate
            // 
            this.buttonAutoUpdate.Location = new System.Drawing.Point(146, 235);
            this.buttonAutoUpdate.Name = "buttonAutoUpdate";
            this.buttonAutoUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoUpdate.TabIndex = 6;
            this.buttonAutoUpdate.Text = "Edit";
            this.buttonAutoUpdate.UseVisualStyleBackColor = true;
            this.buttonAutoUpdate.Click += new System.EventHandler(this.buttonAutoUpdate_Click);
            // 
            // buttonAutoDelete
            // 
            this.buttonAutoDelete.Location = new System.Drawing.Point(244, 235);
            this.buttonAutoDelete.Name = "buttonAutoDelete";
            this.buttonAutoDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonAutoDelete.TabIndex = 7;
            this.buttonAutoDelete.Text = "Obrisi";
            this.buttonAutoDelete.UseVisualStyleBackColor = true;
            this.buttonAutoDelete.Click += new System.EventHandler(this.buttonAutoDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(640, 389);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Izlaz";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBackAuto
            // 
            this.buttonBackAuto.Location = new System.Drawing.Point(57, 388);
            this.buttonBackAuto.Name = "buttonBackAuto";
            this.buttonBackAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonBackAuto.TabIndex = 9;
            this.buttonBackAuto.Text = "Nazad";
            this.buttonBackAuto.UseVisualStyleBackColor = true;
            this.buttonBackAuto.Click += new System.EventHandler(this.buttonBackAuto_Click);
            // 
            // FormAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBackAuto);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAutoDelete);
            this.Controls.Add(this.buttonAutoUpdate);
            this.Controls.Add(this.buttonAutoSave);
            this.Controls.Add(this.textBoxAutoNaziv);
            this.Controls.Add(this.textBoxAutoMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAuto);
            this.Name = "FormAuto";
            this.Text = "FormAuto";
            this.Load += new System.EventHandler(this.FormAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAutoMarka;
        private System.Windows.Forms.TextBox textBoxAutoNaziv;
        private System.Windows.Forms.Button buttonAutoSave;
        private System.Windows.Forms.Button buttonAutoUpdate;
        private System.Windows.Forms.Button buttonAutoDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBackAuto;
    }
}