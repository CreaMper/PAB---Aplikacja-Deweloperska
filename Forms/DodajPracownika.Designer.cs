namespace Aplikacja_deweloperska_2
{
    partial class DodaPracownika
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
            this.lbl_DodajPracownika = new System.Windows.Forms.Label();
            this.lbl_Imie = new System.Windows.Forms.Label();
            this.dodaj_imie = new System.Windows.Forms.TextBox();
            this.lblImie = new System.Windows.Forms.Label();
            this.dodaj_nazwisko = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.dodaj_adres = new System.Windows.Forms.TextBox();
            this.dodajTelefon = new System.Windows.Forms.Label();
            this.dodaj_telefon = new System.Windows.Forms.TextBox();
            this.lblPesel = new System.Windows.Forms.Label();
            this.dodaj_pesel = new System.Windows.Forms.TextBox();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.dodaj_stanowisko = new System.Windows.Forms.TextBox();
            this.btnDodajPracownika = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dodaj_email = new System.Windows.Forms.TextBox();
            this.bsPracownicy = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsPracownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DodajPracownika
            // 
            this.lbl_DodajPracownika.AutoSize = true;
            this.lbl_DodajPracownika.Location = new System.Drawing.Point(12, 9);
            this.lbl_DodajPracownika.Name = "lbl_DodajPracownika";
            this.lbl_DodajPracownika.Size = new System.Drawing.Size(193, 13);
            this.lbl_DodajPracownika.TabIndex = 0;
            this.lbl_DodajPracownika.Text = "Menu Dodawania Nowego Pracownika";
            // 
            // lbl_Imie
            // 
            this.lbl_Imie.AutoSize = true;
            this.lbl_Imie.Location = new System.Drawing.Point(12, 42);
            this.lbl_Imie.Name = "lbl_Imie";
            this.lbl_Imie.Size = new System.Drawing.Size(26, 13);
            this.lbl_Imie.TabIndex = 1;
            this.lbl_Imie.Text = "Imie";
            // 
            // dodaj_imie
            // 
            this.dodaj_imie.Location = new System.Drawing.Point(80, 39);
            this.dodaj_imie.Name = "dodaj_imie";
            this.dodaj_imie.Size = new System.Drawing.Size(144, 20);
            this.dodaj_imie.TabIndex = 2;
            this.dodaj_imie.TextChanged += new System.EventHandler(this.dodaj_imie_TextChanged);
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(12, 68);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(53, 13);
            this.lblImie.TabIndex = 3;
            this.lblImie.Text = "Nazwisko";
            this.lblImie.Click += new System.EventHandler(this.label1_Click);
            // 
            // dodaj_nazwisko
            // 
            this.dodaj_nazwisko.Location = new System.Drawing.Point(80, 68);
            this.dodaj_nazwisko.Name = "dodaj_nazwisko";
            this.dodaj_nazwisko.Size = new System.Drawing.Size(144, 20);
            this.dodaj_nazwisko.TabIndex = 4;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(12, 98);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres";
            this.lblAdres.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dodaj_adres
            // 
            this.dodaj_adres.Location = new System.Drawing.Point(80, 97);
            this.dodaj_adres.Name = "dodaj_adres";
            this.dodaj_adres.Size = new System.Drawing.Size(144, 20);
            this.dodaj_adres.TabIndex = 6;
            // 
            // dodajTelefon
            // 
            this.dodajTelefon.AutoSize = true;
            this.dodajTelefon.Location = new System.Drawing.Point(12, 156);
            this.dodajTelefon.Name = "dodajTelefon";
            this.dodajTelefon.Size = new System.Drawing.Size(43, 13);
            this.dodajTelefon.TabIndex = 7;
            this.dodajTelefon.Text = "Telefon";
            // 
            // dodaj_telefon
            // 
            this.dodaj_telefon.Location = new System.Drawing.Point(80, 156);
            this.dodaj_telefon.Name = "dodaj_telefon";
            this.dodaj_telefon.Size = new System.Drawing.Size(144, 20);
            this.dodaj_telefon.TabIndex = 8;
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Location = new System.Drawing.Point(12, 185);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(33, 13);
            this.lblPesel.TabIndex = 9;
            this.lblPesel.Text = "Pesel";
            // 
            // dodaj_pesel
            // 
            this.dodaj_pesel.Location = new System.Drawing.Point(80, 185);
            this.dodaj_pesel.Name = "dodaj_pesel";
            this.dodaj_pesel.Size = new System.Drawing.Size(144, 20);
            this.dodaj_pesel.TabIndex = 10;
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Location = new System.Drawing.Point(12, 217);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(62, 13);
            this.lblStanowisko.TabIndex = 11;
            this.lblStanowisko.Text = "Stanowisko";
            // 
            // dodaj_stanowisko
            // 
            this.dodaj_stanowisko.Location = new System.Drawing.Point(80, 214);
            this.dodaj_stanowisko.Name = "dodaj_stanowisko";
            this.dodaj_stanowisko.Size = new System.Drawing.Size(144, 20);
            this.dodaj_stanowisko.TabIndex = 12;
            this.dodaj_stanowisko.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDodajPracownika
            // 
            this.btnDodajPracownika.Location = new System.Drawing.Point(80, 252);
            this.btnDodajPracownika.Name = "btnDodajPracownika";
            this.btnDodajPracownika.Size = new System.Drawing.Size(144, 20);
            this.btnDodajPracownika.TabIndex = 15;
            this.btnDodajPracownika.Text = "Dodaj Pracownika";
            this.btnDodajPracownika.UseVisualStyleBackColor = true;
            this.btnDodajPracownika.Click += new System.EventHandler(this.btnDodajPracownika_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // dodaj_email
            // 
            this.dodaj_email.Location = new System.Drawing.Point(80, 123);
            this.dodaj_email.Name = "dodaj_email";
            this.dodaj_email.Size = new System.Drawing.Size(144, 20);
            this.dodaj_email.TabIndex = 17;
            // 
            // bsPracownicy
            // 
            this.bsPracownicy.DataSource = typeof(Aplikacja_deweloperska_2.PRACOWNICY);
            this.bsPracownicy.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // DodaPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 366);
            this.Controls.Add(this.dodaj_email);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnDodajPracownika);
            this.Controls.Add(this.dodaj_stanowisko);
            this.Controls.Add(this.lblStanowisko);
            this.Controls.Add(this.dodaj_pesel);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.dodaj_telefon);
            this.Controls.Add(this.dodajTelefon);
            this.Controls.Add(this.dodaj_adres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.dodaj_nazwisko);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.dodaj_imie);
            this.Controls.Add(this.lbl_Imie);
            this.Controls.Add(this.lbl_DodajPracownika);
            this.Name = "DodaPracownika";
            this.Text = "DodaPracownika";
            this.Load += new System.EventHandler(this.DodaPracownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPracownicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DodajPracownika;
        private System.Windows.Forms.Label lbl_Imie;
        private System.Windows.Forms.TextBox dodaj_imie;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.TextBox dodaj_nazwisko;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox dodaj_adres;
        private System.Windows.Forms.Label dodajTelefon;
        private System.Windows.Forms.TextBox dodaj_telefon;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.TextBox dodaj_pesel;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.TextBox dodaj_stanowisko;
        private System.Windows.Forms.Button btnDodajPracownika;
        private System.Windows.Forms.BindingSource bsPracownicy;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox dodaj_email;
    }
}