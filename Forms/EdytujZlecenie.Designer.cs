namespace Aplikacja_deweloperska_2.Forms
{
    partial class EdytujZlecenie
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
            this.ukonczono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnZakonczEdycje = new System.Windows.Forms.Button();
            this.opis = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.rozpoczeto = new System.Windows.Forms.TextBox();
            this.dodajTelefon = new System.Windows.Forms.Label();
            this.zespol = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.priorytet = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.numer = new System.Windows.Forms.TextBox();
            this.lbl_Imie = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ukonczono
            // 
            this.ukonczono.Location = new System.Drawing.Point(86, 96);
            this.ukonczono.Name = "ukonczono";
            this.ukonczono.Size = new System.Drawing.Size(144, 20);
            this.ukonczono.TabIndex = 32;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Ukonczono";
            // 
            // btnZakonczEdycje
            // 
            this.btnZakonczEdycje.Location = new System.Drawing.Point(86, 235);
            this.btnZakonczEdycje.Name = "btnZakonczEdycje";
            this.btnZakonczEdycje.Size = new System.Drawing.Size(144, 20);
            this.btnZakonczEdycje.TabIndex = 30;
            this.btnZakonczEdycje.Text = "Edytuj";
            this.btnZakonczEdycje.UseVisualStyleBackColor = true;
            // 
            // opis
            // 
            this.opis.Location = new System.Drawing.Point(88, 155);
            this.opis.Multiline = true;
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(144, 74);
            this.opis.TabIndex = 27;
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Location = new System.Drawing.Point(18, 155);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(28, 13);
            this.lblPesel.TabIndex = 26;
            this.lblPesel.Text = "Opis";
            // 
            // rozpoczeto
            // 
            this.rozpoczeto.Location = new System.Drawing.Point(88, 122);
            this.rozpoczeto.Name = "rozpoczeto";
            this.rozpoczeto.Size = new System.Drawing.Size(144, 20);
            this.rozpoczeto.TabIndex = 25;
            // 
            // dodajTelefon
            // 
            this.dodajTelefon.AutoSize = true;
            this.dodajTelefon.Location = new System.Drawing.Point(18, 129);
            this.dodajTelefon.Name = "dodajTelefon";
            this.dodajTelefon.Size = new System.Drawing.Size(64, 13);
            this.dodajTelefon.TabIndex = 24;
            this.dodajTelefon.Text = "Rozpoczęto";
            this.dodajTelefon.Click += new System.EventHandler(this.dodajTelefon_Click);
            // 
            // zespol
            // 
            this.zespol.Location = new System.Drawing.Point(86, 70);
            this.zespol.Name = "zespol";
            this.zespol.Size = new System.Drawing.Size(144, 20);
            this.zespol.TabIndex = 23;
            this.zespol.TextChanged += new System.EventHandler(this.zespol_TextChanged);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(18, 71);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(39, 13);
            this.lblAdres.TabIndex = 22;
            this.lblAdres.Text = "Zespol";
            // 
            // priorytet
            // 
            this.priorytet.Location = new System.Drawing.Point(86, 41);
            this.priorytet.Name = "priorytet";
            this.priorytet.Size = new System.Drawing.Size(144, 20);
            this.priorytet.TabIndex = 21;
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(18, 41);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(45, 13);
            this.lblImie.TabIndex = 20;
            this.lblImie.Text = "Priorytet";
            // 
            // numer
            // 
            this.numer.Location = new System.Drawing.Point(86, 12);
            this.numer.Name = "numer";
            this.numer.ReadOnly = true;
            this.numer.Size = new System.Drawing.Size(79, 20);
            this.numer.TabIndex = 19;
            // 
            // lbl_Imie
            // 
            this.lbl_Imie.AutoSize = true;
            this.lbl_Imie.Location = new System.Drawing.Point(18, 15);
            this.lbl_Imie.Name = "lbl_Imie";
            this.lbl_Imie.Size = new System.Drawing.Size(41, 13);
            this.lbl_Imie.TabIndex = 18;
            this.lbl_Imie.Text = "Numer ";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1165, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(10, 20);
            this.dataGridView1.TabIndex = 33;
            // 
            // EdytujZlecenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 277);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ukonczono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnZakonczEdycje);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.rozpoczeto);
            this.Controls.Add(this.dodajTelefon);
            this.Controls.Add(this.zespol);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.priorytet);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.numer);
            this.Controls.Add(this.lbl_Imie);
            this.Name = "EdytujZlecenie";
            this.Text = "EdytujZlecenie";
            this.Load += new System.EventHandler(this.EdytujZlecenie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ukonczono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnZakonczEdycje;
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.TextBox rozpoczeto;
        private System.Windows.Forms.Label dodajTelefon;
        private System.Windows.Forms.TextBox zespol;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox priorytet;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox numer;
        private System.Windows.Forms.Label lbl_Imie;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}