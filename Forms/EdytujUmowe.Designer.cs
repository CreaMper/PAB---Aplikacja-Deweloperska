namespace Aplikacja_deweloperska_2.Forms
{
    partial class EdytujUmowe
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
            this.lbl_zatrudnionyDo = new System.Windows.Forms.Label();
            this.lblZatrudnionyOd = new System.Windows.Forms.Label();
            this.lblPensja = new System.Windows.Forms.Label();
            this.lblUmowa = new System.Windows.Forms.Label();
            this.btnDodajZmien = new System.Windows.Forms.Button();
            this.inputNrUmowy = new System.Windows.Forms.TextBox();
            this.inputPensja = new System.Windows.Forms.TextBox();
            this.dateZatrudnionyOD = new System.Windows.Forms.DateTimePicker();
            this.dateZatrudnionyDo = new System.Windows.Forms.DateTimePicker();
            this.uMOWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uMOWYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_zatrudnionyDo
            // 
            this.lbl_zatrudnionyDo.AutoSize = true;
            this.lbl_zatrudnionyDo.Location = new System.Drawing.Point(21, 103);
            this.lbl_zatrudnionyDo.Name = "lbl_zatrudnionyDo";
            this.lbl_zatrudnionyDo.Size = new System.Drawing.Size(80, 13);
            this.lbl_zatrudnionyDo.TabIndex = 65;
            this.lbl_zatrudnionyDo.Text = "Zatrudniony Do";
            // 
            // lblZatrudnionyOd
            // 
            this.lblZatrudnionyOd.AutoSize = true;
            this.lblZatrudnionyOd.Location = new System.Drawing.Point(21, 75);
            this.lblZatrudnionyOd.Name = "lblZatrudnionyOd";
            this.lblZatrudnionyOd.Size = new System.Drawing.Size(80, 13);
            this.lblZatrudnionyOd.TabIndex = 64;
            this.lblZatrudnionyOd.Text = "Zatrudniony Od";
            // 
            // lblPensja
            // 
            this.lblPensja.AutoSize = true;
            this.lblPensja.Location = new System.Drawing.Point(21, 49);
            this.lblPensja.Name = "lblPensja";
            this.lblPensja.Size = new System.Drawing.Size(39, 13);
            this.lblPensja.TabIndex = 63;
            this.lblPensja.Text = "Pensja";
            // 
            // lblUmowa
            // 
            this.lblUmowa.AutoSize = true;
            this.lblUmowa.Location = new System.Drawing.Point(21, 20);
            this.lblUmowa.Name = "lblUmowa";
            this.lblUmowa.Size = new System.Drawing.Size(56, 13);
            this.lblUmowa.TabIndex = 61;
            this.lblUmowa.Text = "Nr Umowy";
            // 
            // btnDodajZmien
            // 
            this.btnDodajZmien.Location = new System.Drawing.Point(24, 140);
            this.btnDodajZmien.Name = "btnDodajZmien";
            this.btnDodajZmien.Size = new System.Drawing.Size(144, 23);
            this.btnDodajZmien.TabIndex = 69;
            this.btnDodajZmien.Text = "Dodaj/Zmien Umowe";
            this.btnDodajZmien.UseVisualStyleBackColor = true;
            this.btnDodajZmien.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputNrUmowy
            // 
            this.inputNrUmowy.Location = new System.Drawing.Point(119, 17);
            this.inputNrUmowy.Name = "inputNrUmowy";
            this.inputNrUmowy.ReadOnly = true;
            this.inputNrUmowy.Size = new System.Drawing.Size(205, 20);
            this.inputNrUmowy.TabIndex = 70;
            this.inputNrUmowy.TextChanged += new System.EventHandler(this.inputNrUmowy_TextChanged);
            // 
            // inputPensja
            // 
            this.inputPensja.Location = new System.Drawing.Point(119, 46);
            this.inputPensja.Name = "inputPensja";
            this.inputPensja.Size = new System.Drawing.Size(205, 20);
            this.inputPensja.TabIndex = 71;
            this.inputPensja.TextChanged += new System.EventHandler(this.inputPensja_TextChanged);
            // 
            // dateZatrudnionyOD
            // 
            this.dateZatrudnionyOD.Location = new System.Drawing.Point(119, 75);
            this.dateZatrudnionyOD.Name = "dateZatrudnionyOD";
            this.dateZatrudnionyOD.Size = new System.Drawing.Size(205, 20);
            this.dateZatrudnionyOD.TabIndex = 74;
            // 
            // dateZatrudnionyDo
            // 
            this.dateZatrudnionyDo.Location = new System.Drawing.Point(119, 103);
            this.dateZatrudnionyDo.Name = "dateZatrudnionyDo";
            this.dateZatrudnionyDo.Size = new System.Drawing.Size(205, 20);
            this.dateZatrudnionyDo.TabIndex = 75;
            // 
            // uMOWYBindingSource
            // 
            this.uMOWYBindingSource.DataSource = typeof(Aplikacja_deweloperska_2.UMOWY);
            // 
            // EdytujUmowe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 197);
            this.Controls.Add(this.dateZatrudnionyDo);
            this.Controls.Add(this.dateZatrudnionyOD);
            this.Controls.Add(this.inputPensja);
            this.Controls.Add(this.inputNrUmowy);
            this.Controls.Add(this.btnDodajZmien);
            this.Controls.Add(this.lbl_zatrudnionyDo);
            this.Controls.Add(this.lblZatrudnionyOd);
            this.Controls.Add(this.lblPensja);
            this.Controls.Add(this.lblUmowa);
            this.Name = "EdytujUmowe";
            this.Text = "EdytujUmowe";
            ((System.ComponentModel.ISupportInitialize)(this.uMOWYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_zatrudnionyDo;
        private System.Windows.Forms.Label lblZatrudnionyOd;
        private System.Windows.Forms.Label lblPensja;
        private System.Windows.Forms.Label lblUmowa;
        private System.Windows.Forms.Button btnDodajZmien;
        private System.Windows.Forms.TextBox inputNrUmowy;
        private System.Windows.Forms.TextBox inputPensja;
        private System.Windows.Forms.DateTimePicker dateZatrudnionyOD;
        private System.Windows.Forms.DateTimePicker dateZatrudnionyDo;
        private System.Windows.Forms.BindingSource uMOWYBindingSource;
    }
}