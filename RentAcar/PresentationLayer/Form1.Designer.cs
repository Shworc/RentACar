
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.RE = new System.Windows.Forms.RichTextBox();
            this.labelReserve = new System.Windows.Forms.Label();
            this.labelInsert = new System.Windows.Forms.Label();
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReserve
            // 
            this.buttonReserve.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonReserve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonReserve.Location = new System.Drawing.Point(283, 88);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(238, 60);
            this.buttonReserve.TabIndex = 0;
            this.buttonReserve.Text = "Rezervacija";
            this.buttonReserve.UseVisualStyleBackColor = false;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.Aqua;
            this.buttonInsert.Location = new System.Drawing.Point(283, 155);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 90);
            this.buttonInsert.TabIndex = 1;
            this.buttonInsert.Text = "Unos";
            this.buttonInsert.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(446, 154);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 91);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Brisanje";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Blue;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(364, 154);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 91);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Editovanje";
            this.buttonEdit.UseVisualStyleBackColor = false;
            // 
            // RE
            // 
            this.RE.Location = new System.Drawing.Point(283, 32);
            this.RE.Name = "RE";
            this.RE.Size = new System.Drawing.Size(238, 35);
            this.RE.TabIndex = 4;
            this.RE.Text = "                        RENT A CAR\nIZNAJMITE AUTOMOBIL PO VASOJ ZELJI";
            // 
            // labelReserve
            // 
            this.labelReserve.AutoSize = true;
            this.labelReserve.Location = new System.Drawing.Point(44, 294);
            this.labelReserve.Name = "labelReserve";
            this.labelReserve.Size = new System.Drawing.Size(198, 13);
            this.labelReserve.TabIndex = 5;
            this.labelReserve.Text = "*Za rezervaciju kliknite na zeleno dugme";
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Location = new System.Drawing.Point(44, 322);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(286, 13);
            this.labelInsert.TabIndex = 6;
            this.labelInsert.Text = "*Za unos novih vozila kliknite na Unos(svetlo plavo dugme)";
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(44, 348);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(192, 13);
            this.labelEdit.TabIndex = 7;
            this.labelEdit.Text = "*Za Editovanje kliknite na plavo dugme";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(44, 373);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(185, 13);
            this.labelDelete.TabIndex = 8;
            this.labelDelete.Text = "*Za brisanje kliknite na crveno dugme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.labelInsert);
            this.Controls.Add(this.labelReserve);
            this.Controls.Add(this.RE);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonReserve);
            this.Name = "Form1";
            this.Text = "RentAcar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.RichTextBox RE;
        private System.Windows.Forms.Label labelReserve;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelDelete;
    }
}

