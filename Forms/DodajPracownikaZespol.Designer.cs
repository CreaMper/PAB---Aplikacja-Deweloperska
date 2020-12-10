namespace Aplikacja_deweloperska_2.Forms
{
    partial class DodajPracownikaZespol
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrdPracownicy = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdPracownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kliknij dwukrotnie aby dodac pracownika który jeszcze nie ma zespołu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgrdPracownicy
            // 
            this.dtgrdPracownicy.AllowUserToAddRows = false;
            this.dtgrdPracownicy.AllowUserToDeleteRows = false;
            this.dtgrdPracownicy.AllowUserToOrderColumns = true;
            this.dtgrdPracownicy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrdPracownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdPracownicy.Location = new System.Drawing.Point(12, 25);
            this.dtgrdPracownicy.MultiSelect = false;
            this.dtgrdPracownicy.Name = "dtgrdPracownicy";
            this.dtgrdPracownicy.ReadOnly = true;
            this.dtgrdPracownicy.RowHeadersVisible = false;
            this.dtgrdPracownicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdPracownicy.Size = new System.Drawing.Size(339, 141);
            this.dtgrdPracownicy.TabIndex = 67;
            this.dtgrdPracownicy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdZespoly_CellContentClick);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(15, 172);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(124, 21);
            this.btnDodaj.TabIndex = 68;
            this.btnDodaj.Text = "Dodaj Pracownika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // DodajPracownikaZespol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 203);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dtgrdPracownicy);
            this.Controls.Add(this.label1);
            this.Name = "DodajPracownikaZespol";
            this.Text = "DodajPracownikaZespol";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdPracownicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrdPracownicy;
        private System.Windows.Forms.Button btnDodaj;
    }
}