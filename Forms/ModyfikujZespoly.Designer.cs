namespace Aplikacja_deweloperska_2.Forms
{
    partial class ModyfikujZespoly
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
            this.dtgrdZespoly = new System.Windows.Forms.DataGridView();
            this.lblZespoly = new System.Windows.Forms.Label();
            this.cboZespoly = new System.Windows.Forms.ComboBox();
            this.dtgrdZlecenia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajZespol = new System.Windows.Forms.Button();
            this.btnEdytujZespol = new System.Windows.Forms.Button();
            this.btnPrzypiszPracownika = new System.Windows.Forms.Button();
            this.btnUsunPracownikaZespol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZespoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZlecenia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdZespoly
            // 
            this.dtgrdZespoly.AllowUserToAddRows = false;
            this.dtgrdZespoly.AllowUserToDeleteRows = false;
            this.dtgrdZespoly.AllowUserToOrderColumns = true;
            this.dtgrdZespoly.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrdZespoly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdZespoly.Location = new System.Drawing.Point(12, 64);
            this.dtgrdZespoly.MultiSelect = false;
            this.dtgrdZespoly.Name = "dtgrdZespoly";
            this.dtgrdZespoly.ReadOnly = true;
            this.dtgrdZespoly.RowHeadersVisible = false;
            this.dtgrdZespoly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdZespoly.Size = new System.Drawing.Size(400, 153);
            this.dtgrdZespoly.TabIndex = 66;
            this.dtgrdZespoly.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdZespoly_CellContentClick);
            // 
            // lblZespoly
            // 
            this.lblZespoly.AutoSize = true;
            this.lblZespoly.Location = new System.Drawing.Point(9, 16);
            this.lblZespoly.Name = "lblZespoly";
            this.lblZespoly.Size = new System.Drawing.Size(39, 13);
            this.lblZespoly.TabIndex = 65;
            this.lblZespoly.Text = "Zespól";
            // 
            // cboZespoly
            // 
            this.cboZespoly.FormattingEnabled = true;
            this.cboZespoly.Location = new System.Drawing.Point(67, 13);
            this.cboZespoly.Name = "cboZespoly";
            this.cboZespoly.Size = new System.Drawing.Size(155, 21);
            this.cboZespoly.TabIndex = 64;
            this.cboZespoly.SelectedIndexChanged += new System.EventHandler(this.cboZespoly_SelectedIndexChanged);
            // 
            // dtgrdZlecenia
            // 
            this.dtgrdZlecenia.AllowUserToAddRows = false;
            this.dtgrdZlecenia.AllowUserToDeleteRows = false;
            this.dtgrdZlecenia.AllowUserToOrderColumns = true;
            this.dtgrdZlecenia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrdZlecenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdZlecenia.Location = new System.Drawing.Point(12, 266);
            this.dtgrdZlecenia.MultiSelect = false;
            this.dtgrdZlecenia.Name = "dtgrdZlecenia";
            this.dtgrdZlecenia.ReadOnly = true;
            this.dtgrdZlecenia.RowHeadersVisible = false;
            this.dtgrdZlecenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdZlecenia.Size = new System.Drawing.Size(811, 155);
            this.dtgrdZlecenia.TabIndex = 67;
            this.dtgrdZlecenia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdZlecenia_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Skład";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Aktywne zlecenia";
            // 
            // btnDodajZespol
            // 
            this.btnDodajZespol.Location = new System.Drawing.Point(242, 13);
            this.btnDodajZespol.Name = "btnDodajZespol";
            this.btnDodajZespol.Size = new System.Drawing.Size(132, 21);
            this.btnDodajZespol.TabIndex = 70;
            this.btnDodajZespol.Text = "Dodaj zespół";
            this.btnDodajZespol.UseVisualStyleBackColor = true;
            this.btnDodajZespol.Click += new System.EventHandler(this.btnDodajZespol_Click);
            // 
            // btnEdytujZespol
            // 
            this.btnEdytujZespol.Location = new System.Drawing.Point(380, 13);
            this.btnEdytujZespol.Name = "btnEdytujZespol";
            this.btnEdytujZespol.Size = new System.Drawing.Size(132, 21);
            this.btnEdytujZespol.TabIndex = 71;
            this.btnEdytujZespol.Text = "Edytuj Zespół";
            this.btnEdytujZespol.UseVisualStyleBackColor = true;
            this.btnEdytujZespol.Click += new System.EventHandler(this.btnEdytujZespol_Click);
            // 
            // btnPrzypiszPracownika
            // 
            this.btnPrzypiszPracownika.Location = new System.Drawing.Point(418, 64);
            this.btnPrzypiszPracownika.Name = "btnPrzypiszPracownika";
            this.btnPrzypiszPracownika.Size = new System.Drawing.Size(128, 23);
            this.btnPrzypiszPracownika.TabIndex = 72;
            this.btnPrzypiszPracownika.Text = "Przypisz Pracownika";
            this.btnPrzypiszPracownika.UseVisualStyleBackColor = true;
            this.btnPrzypiszPracownika.Click += new System.EventHandler(this.btnPrzypiszPracownika_Click);
            // 
            // btnUsunPracownikaZespol
            // 
            this.btnUsunPracownikaZespol.Location = new System.Drawing.Point(418, 194);
            this.btnUsunPracownikaZespol.Name = "btnUsunPracownikaZespol";
            this.btnUsunPracownikaZespol.Size = new System.Drawing.Size(128, 23);
            this.btnUsunPracownikaZespol.TabIndex = 73;
            this.btnUsunPracownikaZespol.Text = "Usuń Pracownika";
            this.btnUsunPracownikaZespol.UseVisualStyleBackColor = true;
            this.btnUsunPracownikaZespol.Click += new System.EventHandler(this.btnUsunPracownikaZespol_Click);
            // 
            // ModyfikujZespoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 433);
            this.Controls.Add(this.btnUsunPracownikaZespol);
            this.Controls.Add(this.btnPrzypiszPracownika);
            this.Controls.Add(this.btnEdytujZespol);
            this.Controls.Add(this.btnDodajZespol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrdZlecenia);
            this.Controls.Add(this.dtgrdZespoly);
            this.Controls.Add(this.lblZespoly);
            this.Controls.Add(this.cboZespoly);
            this.Name = "ModyfikujZespoly";
            this.Text = "ModyfikujZespoly";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZespoly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZlecenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdZespoly;
        private System.Windows.Forms.Label lblZespoly;
        private System.Windows.Forms.ComboBox cboZespoly;
        private System.Windows.Forms.DataGridView dtgrdZlecenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodajZespol;
        private System.Windows.Forms.Button btnEdytujZespol;
        private System.Windows.Forms.Button btnPrzypiszPracownika;
        private System.Windows.Forms.Button btnUsunPracownikaZespol;
    }
}