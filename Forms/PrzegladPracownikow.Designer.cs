namespace Aplikacja_deweloperska_2
{
    partial class PrzegladPracownikow
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
            this.lbl_FirmaDeweloperska = new System.Windows.Forms.Label();
            this.dtgdPracownicy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPracownicyDodaj = new System.Windows.Forms.Button();
            this.pracownicy_edytuj = new System.Windows.Forms.Button();
            this.szczegolyPracownika = new System.Windows.Forms.Button();
            this.pracownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pRACIMIEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACNAZWISKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACSTANOWSKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACPESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACADRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRACTELEFONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPracownicy = new System.Windows.Forms.BindingSource(this.components);
            this.uMOWYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zleceniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdPracownicy)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracownicy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMOWYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FirmaDeweloperska
            // 
            this.lbl_FirmaDeweloperska.AutoSize = true;
            this.lbl_FirmaDeweloperska.Location = new System.Drawing.Point(277, 24);
            this.lbl_FirmaDeweloperska.Name = "lbl_FirmaDeweloperska";
            this.lbl_FirmaDeweloperska.Size = new System.Drawing.Size(217, 13);
            this.lbl_FirmaDeweloperska.TabIndex = 1;
            this.lbl_FirmaDeweloperska.Text = "Firma Deweloperska - Podgląd pracowników";
            this.lbl_FirmaDeweloperska.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgdPracownicy
            // 
            this.dtgdPracownicy.AllowUserToAddRows = false;
            this.dtgdPracownicy.AllowUserToDeleteRows = false;
            this.dtgdPracownicy.AutoGenerateColumns = false;
            this.dtgdPracownicy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgdPracownicy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgdPracownicy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgdPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdPracownicy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.pRACIMIEDataGridViewTextBoxColumn,
            this.pRACNAZWISKODataGridViewTextBoxColumn,
            this.pRACSTANOWSKODataGridViewTextBoxColumn,
            this.pRACPESELDataGridViewTextBoxColumn,
            this.pRACADRESDataGridViewTextBoxColumn,
            this.pRACEMAILDataGridViewTextBoxColumn,
            this.pRACTELEFONDataGridViewTextBoxColumn});
            this.dtgdPracownicy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgdPracownicy.DataSource = this.bsPracownicy;
            this.dtgdPracownicy.EnableHeadersVisualStyles = false;
            this.dtgdPracownicy.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgdPracownicy.Location = new System.Drawing.Point(15, 57);
            this.dtgdPracownicy.MultiSelect = false;
            this.dtgdPracownicy.Name = "dtgdPracownicy";
            this.dtgdPracownicy.ReadOnly = true;
            this.dtgdPracownicy.RowHeadersVisible = false;
            this.dtgdPracownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgdPracownicy.Size = new System.Drawing.Size(748, 259);
            this.dtgdPracownicy.TabIndex = 4;
            this.dtgdPracownicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PRAC_ID";
            this.Column1.HeaderText = "PRAC_ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // btnPracownicyDodaj
            // 
            this.btnPracownicyDodaj.Location = new System.Drawing.Point(15, 322);
            this.btnPracownicyDodaj.Name = "btnPracownicyDodaj";
            this.btnPracownicyDodaj.Size = new System.Drawing.Size(129, 36);
            this.btnPracownicyDodaj.TabIndex = 5;
            this.btnPracownicyDodaj.Text = "Dodaj Pracownika";
            this.btnPracownicyDodaj.UseVisualStyleBackColor = true;
            this.btnPracownicyDodaj.Click += new System.EventHandler(this.btnPracownicyDodaj_Click);
            // 
            // pracownicy_edytuj
            // 
            this.pracownicy_edytuj.Location = new System.Drawing.Point(150, 322);
            this.pracownicy_edytuj.Name = "pracownicy_edytuj";
            this.pracownicy_edytuj.Size = new System.Drawing.Size(129, 36);
            this.pracownicy_edytuj.TabIndex = 6;
            this.pracownicy_edytuj.Text = "Edytuj Pracownika";
            this.pracownicy_edytuj.UseVisualStyleBackColor = true;
            this.pracownicy_edytuj.Click += new System.EventHandler(this.pracownicy_edytuj_Click);
            // 
            // szczegolyPracownika
            // 
            this.szczegolyPracownika.Location = new System.Drawing.Point(285, 322);
            this.szczegolyPracownika.Name = "szczegolyPracownika";
            this.szczegolyPracownika.Size = new System.Drawing.Size(129, 36);
            this.szczegolyPracownika.TabIndex = 7;
            this.szczegolyPracownika.Text = "Szczegóły Pracownika";
            this.szczegolyPracownika.UseVisualStyleBackColor = true;
            this.szczegolyPracownika.Click += new System.EventHandler(this.szczegolyPracownika_Click);
            // 
            // pracownicyToolStripMenuItem
            // 
            this.pracownicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przegladToolStripMenuItem});
            this.pracownicyToolStripMenuItem.Name = "pracownicyToolStripMenuItem";
            this.pracownicyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.pracownicyToolStripMenuItem.Text = "Zespoły";
            this.pracownicyToolStripMenuItem.Click += new System.EventHandler(this.pracownicyToolStripMenuItem_Click);
            // 
            // przegladToolStripMenuItem
            // 
            this.przegladToolStripMenuItem.Name = "przegladToolStripMenuItem";
            this.przegladToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.przegladToolStripMenuItem.Text = "Zarzadzaj";
            this.przegladToolStripMenuItem.Click += new System.EventHandler(this.przegladToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pracownicyToolStripMenuItem,
            this.zleceniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pRACIMIEDataGridViewTextBoxColumn
            // 
            this.pRACIMIEDataGridViewTextBoxColumn.DataPropertyName = "PRAC_IMIE";
            this.pRACIMIEDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.pRACIMIEDataGridViewTextBoxColumn.Name = "pRACIMIEDataGridViewTextBoxColumn";
            this.pRACIMIEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRACNAZWISKODataGridViewTextBoxColumn
            // 
            this.pRACNAZWISKODataGridViewTextBoxColumn.DataPropertyName = "PRAC_NAZWISKO";
            this.pRACNAZWISKODataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.pRACNAZWISKODataGridViewTextBoxColumn.Name = "pRACNAZWISKODataGridViewTextBoxColumn";
            this.pRACNAZWISKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRACSTANOWSKODataGridViewTextBoxColumn
            // 
            this.pRACSTANOWSKODataGridViewTextBoxColumn.DataPropertyName = "PRAC_STANOWSKO";
            this.pRACSTANOWSKODataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.pRACSTANOWSKODataGridViewTextBoxColumn.Name = "pRACSTANOWSKODataGridViewTextBoxColumn";
            this.pRACSTANOWSKODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRACPESELDataGridViewTextBoxColumn
            // 
            this.pRACPESELDataGridViewTextBoxColumn.DataPropertyName = "PRAC_PESEL";
            this.pRACPESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pRACPESELDataGridViewTextBoxColumn.Name = "pRACPESELDataGridViewTextBoxColumn";
            this.pRACPESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRACADRESDataGridViewTextBoxColumn
            // 
            this.pRACADRESDataGridViewTextBoxColumn.DataPropertyName = "PRAC_ADRES";
            this.pRACADRESDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.pRACADRESDataGridViewTextBoxColumn.Name = "pRACADRESDataGridViewTextBoxColumn";
            this.pRACADRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRACEMAILDataGridViewTextBoxColumn
            // 
            this.pRACEMAILDataGridViewTextBoxColumn.DataPropertyName = "PRAC_EMAIL";
            this.pRACEMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.pRACEMAILDataGridViewTextBoxColumn.Name = "pRACEMAILDataGridViewTextBoxColumn";
            this.pRACEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRACTELEFONDataGridViewTextBoxColumn
            // 
            this.pRACTELEFONDataGridViewTextBoxColumn.DataPropertyName = "PRAC_TELEFON";
            this.pRACTELEFONDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.pRACTELEFONDataGridViewTextBoxColumn.Name = "pRACTELEFONDataGridViewTextBoxColumn";
            this.pRACTELEFONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPracownicy
            // 
            this.bsPracownicy.DataSource = typeof(Aplikacja_deweloperska_2.PRACOWNICY);
            this.bsPracownicy.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // uMOWYBindingSource
            // 
            this.uMOWYBindingSource.DataSource = typeof(Aplikacja_deweloperska_2.UMOWY);
            // 
            // zleceniaToolStripMenuItem
            // 
            this.zleceniaToolStripMenuItem.Name = "zleceniaToolStripMenuItem";
            this.zleceniaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zleceniaToolStripMenuItem.Text = "Zlecenia";
            this.zleceniaToolStripMenuItem.Click += new System.EventHandler(this.zleceniaToolStripMenuItem_Click);
            // 
            // PrzegladPracownikow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 380);
            this.Controls.Add(this.szczegolyPracownika);
            this.Controls.Add(this.pracownicy_edytuj);
            this.Controls.Add(this.btnPracownicyDodaj);
            this.Controls.Add(this.dtgdPracownicy);
            this.Controls.Add(this.lbl_FirmaDeweloperska);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrzegladPracownikow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgdPracownicy)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPracownicy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMOWYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsPracownicy;
        private System.Windows.Forms.Label lbl_FirmaDeweloperska;
        private System.Windows.Forms.DataGridView dtgdPracownicy;
        private System.Windows.Forms.Button btnPracownicyDodaj;
        private System.Windows.Forms.BindingSource uMOWYBindingSource;
        private System.Windows.Forms.Button pracownicy_edytuj;
        private System.Windows.Forms.Button szczegolyPracownika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACIMIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACNAZWISKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACSTANOWSKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACPESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACADRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRACTELEFONDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem pracownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zleceniaToolStripMenuItem;
    }
}

