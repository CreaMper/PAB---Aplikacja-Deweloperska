namespace Aplikacja_deweloperska_2.Forms
{
    partial class SzczegolyPracownika
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
            this.lblPowitanie = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStanowisko = new System.Windows.Forms.Label();
            this.lblPesel = new System.Windows.Forms.Label();
            this.dodajTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblImie = new System.Windows.Forms.Label();
            this.lbl_Imie = new System.Windows.Forms.Label();
            this.lblUmowa = new System.Windows.Forms.Label();
            this.lblNrUmowyAdd = new System.Windows.Forms.Label();
            this.lblEmailAdd = new System.Windows.Forms.Label();
            this.lblStanowiskoAdd = new System.Windows.Forms.Label();
            this.lblPeselAdd = new System.Windows.Forms.Label();
            this.lblTelefonAdd = new System.Windows.Forms.Label();
            this.lblAdressAdd = new System.Windows.Forms.Label();
            this.lblNazwiskoAdd = new System.Windows.Forms.Label();
            this.lblImieAdd = new System.Windows.Forms.Label();
            this.dtgrdWydatki = new System.Windows.Forms.DataGridView();
            this.wYDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wYDKWOTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wYDDATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wYDATKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgrdPrzeznaczenie = new System.Windows.Forms.DataGridView();
            this.pRZEZIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRZEZNAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRZEZNUMERSERYJNYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRZEZAKTYWNADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRZEZNACZENIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZmienDodajUmowe = new System.Windows.Forms.Button();
            this.lblPensja = new System.Windows.Forms.Label();
            this.lblZatrudnionyOd = new System.Windows.Forms.Label();
            this.lbl_zatrudnionyDo = new System.Windows.Forms.Label();
            this.lblPensjaAdd = new System.Windows.Forms.Label();
            this.lblZatrudnionyOdAdd = new System.Windows.Forms.Label();
            this.lblZatrudnionyDoAdd = new System.Windows.Forms.Label();
            this.cboZespoly = new System.Windows.Forms.ComboBox();
            this.lblZespoly = new System.Windows.Forms.Label();
            this.dtgrdZespoly = new System.Windows.Forms.DataGridView();
            this.uMOWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdWydatki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wYDATKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdPrzeznaczenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRZEZNACZENIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZespoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMOWYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPowitanie
            // 
            this.lblPowitanie.AutoSize = true;
            this.lblPowitanie.Location = new System.Drawing.Point(12, 9);
            this.lblPowitanie.Name = "lblPowitanie";
            this.lblPowitanie.Size = new System.Drawing.Size(277, 13);
            this.lblPowitanie.TabIndex = 0;
            this.lblPowitanie.Text = "Aktualnie znajdujesz się w menu szczegółów pracownika";
            this.lblPowitanie.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email";
            // 
            // lblStanowisko
            // 
            this.lblStanowisko.AutoSize = true;
            this.lblStanowisko.Location = new System.Drawing.Point(21, 229);
            this.lblStanowisko.Name = "lblStanowisko";
            this.lblStanowisko.Size = new System.Drawing.Size(62, 13);
            this.lblStanowisko.TabIndex = 38;
            this.lblStanowisko.Text = "Stanowisko";
            // 
            // lblPesel
            // 
            this.lblPesel.AutoSize = true;
            this.lblPesel.Location = new System.Drawing.Point(21, 197);
            this.lblPesel.Name = "lblPesel";
            this.lblPesel.Size = new System.Drawing.Size(33, 13);
            this.lblPesel.TabIndex = 37;
            this.lblPesel.Text = "Pesel";
            // 
            // dodajTelefon
            // 
            this.dodajTelefon.AutoSize = true;
            this.dodajTelefon.Location = new System.Drawing.Point(21, 168);
            this.dodajTelefon.Name = "dodajTelefon";
            this.dodajTelefon.Size = new System.Drawing.Size(43, 13);
            this.dodajTelefon.TabIndex = 36;
            this.dodajTelefon.Text = "Telefon";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(21, 110);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(34, 13);
            this.lblAdres.TabIndex = 35;
            this.lblAdres.Text = "Adres";
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Location = new System.Drawing.Point(21, 80);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(53, 13);
            this.lblImie.TabIndex = 34;
            this.lblImie.Text = "Nazwisko";
            // 
            // lbl_Imie
            // 
            this.lbl_Imie.AutoSize = true;
            this.lbl_Imie.Location = new System.Drawing.Point(21, 54);
            this.lbl_Imie.Name = "lbl_Imie";
            this.lbl_Imie.Size = new System.Drawing.Size(26, 13);
            this.lbl_Imie.TabIndex = 33;
            this.lbl_Imie.Text = "Imie";
            // 
            // lblUmowa
            // 
            this.lblUmowa.AutoSize = true;
            this.lblUmowa.Location = new System.Drawing.Point(12, 335);
            this.lblUmowa.Name = "lblUmowa";
            this.lblUmowa.Size = new System.Drawing.Size(56, 13);
            this.lblUmowa.TabIndex = 40;
            this.lblUmowa.Text = "Nr Umowy";
            this.lblUmowa.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblNrUmowyAdd
            // 
            this.lblNrUmowyAdd.AutoSize = true;
            this.lblNrUmowyAdd.Location = new System.Drawing.Point(103, 335);
            this.lblNrUmowyAdd.Name = "lblNrUmowyAdd";
            this.lblNrUmowyAdd.Size = new System.Drawing.Size(56, 13);
            this.lblNrUmowyAdd.TabIndex = 48;
            this.lblNrUmowyAdd.Text = "Nr Umowy";
            this.lblNrUmowyAdd.Click += new System.EventHandler(this.lblNrUmowyAdd_Click);
            // 
            // lblEmailAdd
            // 
            this.lblEmailAdd.AutoSize = true;
            this.lblEmailAdd.Location = new System.Drawing.Point(116, 138);
            this.lblEmailAdd.Name = "lblEmailAdd";
            this.lblEmailAdd.Size = new System.Drawing.Size(32, 13);
            this.lblEmailAdd.TabIndex = 47;
            this.lblEmailAdd.Text = "Email";
            // 
            // lblStanowiskoAdd
            // 
            this.lblStanowiskoAdd.AutoSize = true;
            this.lblStanowiskoAdd.Location = new System.Drawing.Point(116, 229);
            this.lblStanowiskoAdd.Name = "lblStanowiskoAdd";
            this.lblStanowiskoAdd.Size = new System.Drawing.Size(62, 13);
            this.lblStanowiskoAdd.TabIndex = 46;
            this.lblStanowiskoAdd.Text = "Stanowisko";
            // 
            // lblPeselAdd
            // 
            this.lblPeselAdd.AutoSize = true;
            this.lblPeselAdd.Location = new System.Drawing.Point(116, 197);
            this.lblPeselAdd.Name = "lblPeselAdd";
            this.lblPeselAdd.Size = new System.Drawing.Size(33, 13);
            this.lblPeselAdd.TabIndex = 45;
            this.lblPeselAdd.Text = "Pesel";
            // 
            // lblTelefonAdd
            // 
            this.lblTelefonAdd.AutoSize = true;
            this.lblTelefonAdd.Location = new System.Drawing.Point(116, 168);
            this.lblTelefonAdd.Name = "lblTelefonAdd";
            this.lblTelefonAdd.Size = new System.Drawing.Size(43, 13);
            this.lblTelefonAdd.TabIndex = 44;
            this.lblTelefonAdd.Text = "Telefon";
            // 
            // lblAdressAdd
            // 
            this.lblAdressAdd.AutoSize = true;
            this.lblAdressAdd.Location = new System.Drawing.Point(116, 110);
            this.lblAdressAdd.Name = "lblAdressAdd";
            this.lblAdressAdd.Size = new System.Drawing.Size(34, 13);
            this.lblAdressAdd.TabIndex = 43;
            this.lblAdressAdd.Text = "Adres";
            // 
            // lblNazwiskoAdd
            // 
            this.lblNazwiskoAdd.AutoSize = true;
            this.lblNazwiskoAdd.Location = new System.Drawing.Point(116, 80);
            this.lblNazwiskoAdd.Name = "lblNazwiskoAdd";
            this.lblNazwiskoAdd.Size = new System.Drawing.Size(53, 13);
            this.lblNazwiskoAdd.TabIndex = 42;
            this.lblNazwiskoAdd.Text = "Nazwisko";
            // 
            // lblImieAdd
            // 
            this.lblImieAdd.AutoSize = true;
            this.lblImieAdd.Location = new System.Drawing.Point(116, 54);
            this.lblImieAdd.Name = "lblImieAdd";
            this.lblImieAdd.Size = new System.Drawing.Size(26, 13);
            this.lblImieAdd.TabIndex = 41;
            this.lblImieAdd.Text = "Imie";
            // 
            // dtgrdWydatki
            // 
            this.dtgrdWydatki.AllowUserToAddRows = false;
            this.dtgrdWydatki.AllowUserToDeleteRows = false;
            this.dtgrdWydatki.AllowUserToOrderColumns = true;
            this.dtgrdWydatki.AutoGenerateColumns = false;
            this.dtgrdWydatki.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrdWydatki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdWydatki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wYDIDDataGridViewTextBoxColumn,
            this.wYDKWOTADataGridViewTextBoxColumn,
            this.wYDDATADataGridViewTextBoxColumn});
            this.dtgrdWydatki.DataSource = this.wYDATKIBindingSource;
            this.dtgrdWydatki.Location = new System.Drawing.Point(212, 69);
            this.dtgrdWydatki.MultiSelect = false;
            this.dtgrdWydatki.Name = "dtgrdWydatki";
            this.dtgrdWydatki.ReadOnly = true;
            this.dtgrdWydatki.RowHeadersVisible = false;
            this.dtgrdWydatki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdWydatki.Size = new System.Drawing.Size(210, 156);
            this.dtgrdWydatki.TabIndex = 49;
            this.dtgrdWydatki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wYDIDDataGridViewTextBoxColumn
            // 
            this.wYDIDDataGridViewTextBoxColumn.DataPropertyName = "WYD_ID";
            this.wYDIDDataGridViewTextBoxColumn.HeaderText = "Nr Wydatku";
            this.wYDIDDataGridViewTextBoxColumn.Name = "wYDIDDataGridViewTextBoxColumn";
            this.wYDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.wYDIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // wYDKWOTADataGridViewTextBoxColumn
            // 
            this.wYDKWOTADataGridViewTextBoxColumn.DataPropertyName = "WYD_KWOTA";
            this.wYDKWOTADataGridViewTextBoxColumn.HeaderText = "Kwota";
            this.wYDKWOTADataGridViewTextBoxColumn.Name = "wYDKWOTADataGridViewTextBoxColumn";
            this.wYDKWOTADataGridViewTextBoxColumn.ReadOnly = true;
            this.wYDKWOTADataGridViewTextBoxColumn.Width = 70;
            // 
            // wYDDATADataGridViewTextBoxColumn
            // 
            this.wYDDATADataGridViewTextBoxColumn.DataPropertyName = "WYD_DATA";
            this.wYDDATADataGridViewTextBoxColumn.HeaderText = "Data";
            this.wYDDATADataGridViewTextBoxColumn.Name = "wYDDATADataGridViewTextBoxColumn";
            this.wYDDATADataGridViewTextBoxColumn.ReadOnly = true;
            this.wYDDATADataGridViewTextBoxColumn.Width = 70;
            // 
            // wYDATKIBindingSource
            // 
            this.wYDATKIBindingSource.DataSource = typeof(Aplikacja_deweloperska_2.WYDATKI);
            // 
            // dtgrdPrzeznaczenie
            // 
            this.dtgrdPrzeznaczenie.AllowUserToAddRows = false;
            this.dtgrdPrzeznaczenie.AllowUserToDeleteRows = false;
            this.dtgrdPrzeznaczenie.AllowUserToOrderColumns = true;
            this.dtgrdPrzeznaczenie.AutoGenerateColumns = false;
            this.dtgrdPrzeznaczenie.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrdPrzeznaczenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdPrzeznaczenie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRZEZIDDataGridViewTextBoxColumn,
            this.pRZEZNAZWADataGridViewTextBoxColumn,
            this.pRZEZNUMERSERYJNYDataGridViewTextBoxColumn,
            this.pRZEZAKTYWNADODataGridViewTextBoxColumn});
            this.dtgrdPrzeznaczenie.DataSource = this.pRZEZNACZENIEBindingSource;
            this.dtgrdPrzeznaczenie.Location = new System.Drawing.Point(428, 69);
            this.dtgrdPrzeznaczenie.MultiSelect = false;
            this.dtgrdPrzeznaczenie.Name = "dtgrdPrzeznaczenie";
            this.dtgrdPrzeznaczenie.ReadOnly = true;
            this.dtgrdPrzeznaczenie.RowHeadersVisible = false;
            this.dtgrdPrzeznaczenie.Size = new System.Drawing.Size(517, 156);
            this.dtgrdPrzeznaczenie.TabIndex = 51;
            // 
            // pRZEZIDDataGridViewTextBoxColumn
            // 
            this.pRZEZIDDataGridViewTextBoxColumn.DataPropertyName = "PRZEZ_ID";
            this.pRZEZIDDataGridViewTextBoxColumn.HeaderText = "Nr Celu";
            this.pRZEZIDDataGridViewTextBoxColumn.Name = "pRZEZIDDataGridViewTextBoxColumn";
            this.pRZEZIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pRZEZIDDataGridViewTextBoxColumn.Width = 60;
            // 
            // pRZEZNAZWADataGridViewTextBoxColumn
            // 
            this.pRZEZNAZWADataGridViewTextBoxColumn.DataPropertyName = "PRZEZ_NAZWA";
            this.pRZEZNAZWADataGridViewTextBoxColumn.HeaderText = "Opis";
            this.pRZEZNAZWADataGridViewTextBoxColumn.Name = "pRZEZNAZWADataGridViewTextBoxColumn";
            this.pRZEZNAZWADataGridViewTextBoxColumn.ReadOnly = true;
            this.pRZEZNAZWADataGridViewTextBoxColumn.Width = 250;
            // 
            // pRZEZNUMERSERYJNYDataGridViewTextBoxColumn
            // 
            this.pRZEZNUMERSERYJNYDataGridViewTextBoxColumn.DataPropertyName = "PRZEZ_NUMER_SERYJNY";
            this.pRZEZNUMERSERYJNYDataGridViewTextBoxColumn.HeaderText = "Numer Seryjny";
            this.pRZEZNUMERSERYJNYDataGridViewTextBoxColumn.Name = "pRZEZNUMERSERYJNYDataGridViewTextBoxColumn";
            this.pRZEZNUMERSERYJNYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRZEZAKTYWNADODataGridViewTextBoxColumn
            // 
            this.pRZEZAKTYWNADODataGridViewTextBoxColumn.DataPropertyName = "PRZEZ_AKTYWNA_DO";
            this.pRZEZAKTYWNADODataGridViewTextBoxColumn.HeaderText = "Aktywna Do";
            this.pRZEZAKTYWNADODataGridViewTextBoxColumn.Name = "pRZEZAKTYWNADODataGridViewTextBoxColumn";
            this.pRZEZAKTYWNADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRZEZNACZENIEBindingSource
            // 
            this.pRZEZNACZENIEBindingSource.DataSource = typeof(Aplikacja_deweloperska_2.PRZEZNACZENIE);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Wydatki pracownika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Szeczgoly wydatkow";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnZmienDodajUmowe
            // 
            this.btnZmienDodajUmowe.Location = new System.Drawing.Point(5, 277);
            this.btnZmienDodajUmowe.Name = "btnZmienDodajUmowe";
            this.btnZmienDodajUmowe.Size = new System.Drawing.Size(87, 44);
            this.btnZmienDodajUmowe.TabIndex = 54;
            this.btnZmienDodajUmowe.Text = "Zmien/Dodaj Umowe";
            this.btnZmienDodajUmowe.UseVisualStyleBackColor = true;
            this.btnZmienDodajUmowe.Click += new System.EventHandler(this.btnZmienDodajUmowe_Click);
            // 
            // lblPensja
            // 
            this.lblPensja.AutoSize = true;
            this.lblPensja.Location = new System.Drawing.Point(12, 364);
            this.lblPensja.Name = "lblPensja";
            this.lblPensja.Size = new System.Drawing.Size(39, 13);
            this.lblPensja.TabIndex = 55;
            this.lblPensja.Text = "Pensja";
            this.lblPensja.Click += new System.EventHandler(this.lblPensja_Click);
            // 
            // lblZatrudnionyOd
            // 
            this.lblZatrudnionyOd.AutoSize = true;
            this.lblZatrudnionyOd.Location = new System.Drawing.Point(12, 390);
            this.lblZatrudnionyOd.Name = "lblZatrudnionyOd";
            this.lblZatrudnionyOd.Size = new System.Drawing.Size(80, 13);
            this.lblZatrudnionyOd.TabIndex = 56;
            this.lblZatrudnionyOd.Text = "Zatrudniony Od";
            this.lblZatrudnionyOd.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_zatrudnionyDo
            // 
            this.lbl_zatrudnionyDo.AutoSize = true;
            this.lbl_zatrudnionyDo.Location = new System.Drawing.Point(12, 418);
            this.lbl_zatrudnionyDo.Name = "lbl_zatrudnionyDo";
            this.lbl_zatrudnionyDo.Size = new System.Drawing.Size(80, 13);
            this.lbl_zatrudnionyDo.TabIndex = 57;
            this.lbl_zatrudnionyDo.Text = "Zatrudniony Do";
            // 
            // lblPensjaAdd
            // 
            this.lblPensjaAdd.AutoSize = true;
            this.lblPensjaAdd.Location = new System.Drawing.Point(103, 364);
            this.lblPensjaAdd.Name = "lblPensjaAdd";
            this.lblPensjaAdd.Size = new System.Drawing.Size(56, 13);
            this.lblPensjaAdd.TabIndex = 58;
            this.lblPensjaAdd.Text = "Nr Umowy";
            // 
            // lblZatrudnionyOdAdd
            // 
            this.lblZatrudnionyOdAdd.AutoSize = true;
            this.lblZatrudnionyOdAdd.Location = new System.Drawing.Point(103, 390);
            this.lblZatrudnionyOdAdd.Name = "lblZatrudnionyOdAdd";
            this.lblZatrudnionyOdAdd.Size = new System.Drawing.Size(80, 13);
            this.lblZatrudnionyOdAdd.TabIndex = 59;
            this.lblZatrudnionyOdAdd.Text = "Zatrudniony Od";
            // 
            // lblZatrudnionyDoAdd
            // 
            this.lblZatrudnionyDoAdd.AutoSize = true;
            this.lblZatrudnionyDoAdd.Location = new System.Drawing.Point(103, 418);
            this.lblZatrudnionyDoAdd.Name = "lblZatrudnionyDoAdd";
            this.lblZatrudnionyDoAdd.Size = new System.Drawing.Size(80, 13);
            this.lblZatrudnionyDoAdd.TabIndex = 60;
            this.lblZatrudnionyDoAdd.Text = "Zatrudniony Od";
            // 
            // cboZespoly
            // 
            this.cboZespoly.FormattingEnabled = true;
            this.cboZespoly.Location = new System.Drawing.Point(267, 277);
            this.cboZespoly.Name = "cboZespoly";
            this.cboZespoly.Size = new System.Drawing.Size(155, 21);
            this.cboZespoly.TabIndex = 61;
            this.cboZespoly.SelectedIndexChanged += new System.EventHandler(this.cboZespoly_SelectedIndexChanged);
            // 
            // lblZespoly
            // 
            this.lblZespoly.AutoSize = true;
            this.lblZespoly.Location = new System.Drawing.Point(209, 280);
            this.lblZespoly.Name = "lblZespoly";
            this.lblZespoly.Size = new System.Drawing.Size(46, 13);
            this.lblZespoly.TabIndex = 62;
            this.lblZespoly.Text = "Zespoły";
            this.lblZespoly.Click += new System.EventHandler(this.lblZespoly_Click);
            // 
            // dtgrdZespoly
            // 
            this.dtgrdZespoly.AllowUserToAddRows = false;
            this.dtgrdZespoly.AllowUserToDeleteRows = false;
            this.dtgrdZespoly.AllowUserToOrderColumns = true;
            this.dtgrdZespoly.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrdZespoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdZespoly.Location = new System.Drawing.Point(212, 304);
            this.dtgrdZespoly.MultiSelect = false;
            this.dtgrdZespoly.Name = "dtgrdZespoly";
            this.dtgrdZespoly.ReadOnly = true;
            this.dtgrdZespoly.RowHeadersVisible = false;
            this.dtgrdZespoly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdZespoly.Size = new System.Drawing.Size(410, 153);
            this.dtgrdZespoly.TabIndex = 63;
            this.dtgrdZespoly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // uMOWYBindingSource
            // 
            this.uMOWYBindingSource.DataSource = typeof(Aplikacja_deweloperska_2.UMOWY);
            // 
            // SzczegolyPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 461);
            this.Controls.Add(this.dtgrdZespoly);
            this.Controls.Add(this.lblZespoly);
            this.Controls.Add(this.cboZespoly);
            this.Controls.Add(this.lblZatrudnionyDoAdd);
            this.Controls.Add(this.lblZatrudnionyOdAdd);
            this.Controls.Add(this.lblPensjaAdd);
            this.Controls.Add(this.lbl_zatrudnionyDo);
            this.Controls.Add(this.lblZatrudnionyOd);
            this.Controls.Add(this.lblPensja);
            this.Controls.Add(this.btnZmienDodajUmowe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrdPrzeznaczenie);
            this.Controls.Add(this.dtgrdWydatki);
            this.Controls.Add(this.lblNrUmowyAdd);
            this.Controls.Add(this.lblEmailAdd);
            this.Controls.Add(this.lblStanowiskoAdd);
            this.Controls.Add(this.lblPeselAdd);
            this.Controls.Add(this.lblTelefonAdd);
            this.Controls.Add(this.lblAdressAdd);
            this.Controls.Add(this.lblNazwiskoAdd);
            this.Controls.Add(this.lblImieAdd);
            this.Controls.Add(this.lblUmowa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblStanowisko);
            this.Controls.Add(this.lblPesel);
            this.Controls.Add(this.dodajTelefon);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.lbl_Imie);
            this.Controls.Add(this.lblPowitanie);
            this.Name = "SzczegolyPracownika";
            this.Text = "SzczegolyPracownika";
            this.Load += new System.EventHandler(this.SzczegolyPracownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdWydatki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wYDATKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdPrzeznaczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRZEZNACZENIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZespoly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMOWYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPowitanie;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStanowisko;
        private System.Windows.Forms.Label lblPesel;
        private System.Windows.Forms.Label dodajTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lbl_Imie;
        private System.Windows.Forms.Label lblUmowa;
        private System.Windows.Forms.Label lblNrUmowyAdd;
        private System.Windows.Forms.Label lblEmailAdd;
        private System.Windows.Forms.Label lblStanowiskoAdd;
        private System.Windows.Forms.Label lblPeselAdd;
        private System.Windows.Forms.Label lblTelefonAdd;
        private System.Windows.Forms.Label lblAdressAdd;
        private System.Windows.Forms.Label lblNazwiskoAdd;
        private System.Windows.Forms.Label lblImieAdd;
        private System.Windows.Forms.DataGridView dtgrdWydatki;
        private System.Windows.Forms.BindingSource wYDATKIBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn wYDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wYDKWOTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wYDDATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dtgrdPrzeznaczenie;
        private System.Windows.Forms.BindingSource pRZEZNACZENIEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRZEZIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRZEZNAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRZEZNUMERSERYJNYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRZEZAKTYWNADODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource uMOWYBindingSource;
        private System.Windows.Forms.Button btnZmienDodajUmowe;
        private System.Windows.Forms.Label lblPensja;
        private System.Windows.Forms.Label lblZatrudnionyOd;
        private System.Windows.Forms.Label lbl_zatrudnionyDo;
        private System.Windows.Forms.Label lblPensjaAdd;
        private System.Windows.Forms.Label lblZatrudnionyOdAdd;
        private System.Windows.Forms.Label lblZatrudnionyDoAdd;
        private System.Windows.Forms.ComboBox cboZespoly;
        private System.Windows.Forms.Label lblZespoly;
        private System.Windows.Forms.DataGridView dtgrdZespoly;
    }
}