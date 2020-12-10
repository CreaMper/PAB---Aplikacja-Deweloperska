namespace Aplikacja_deweloperska_2.Forms
{
    partial class MenuZlecenia
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
            this.btnEdytujZlecenie = new System.Windows.Forms.Button();
            this.btnDodajZlecenie = new System.Windows.Forms.Button();
            this.btnFinanseZlecenia = new System.Windows.Forms.Button();
            this.dtgrdZlecenia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZlecenia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdytujZlecenie
            // 
            this.btnEdytujZlecenie.Location = new System.Drawing.Point(12, 201);
            this.btnEdytujZlecenie.Name = "btnEdytujZlecenie";
            this.btnEdytujZlecenie.Size = new System.Drawing.Size(109, 28);
            this.btnEdytujZlecenie.TabIndex = 1;
            this.btnEdytujZlecenie.Text = "Edytuj Zlecenie";
            this.btnEdytujZlecenie.UseVisualStyleBackColor = true;
            this.btnEdytujZlecenie.Click += new System.EventHandler(this.btnEdytujZlecenie_Click);
            // 
            // btnDodajZlecenie
            // 
            this.btnDodajZlecenie.Location = new System.Drawing.Point(127, 201);
            this.btnDodajZlecenie.Name = "btnDodajZlecenie";
            this.btnDodajZlecenie.Size = new System.Drawing.Size(109, 28);
            this.btnDodajZlecenie.TabIndex = 2;
            this.btnDodajZlecenie.Text = "DodajZlecenie";
            this.btnDodajZlecenie.UseVisualStyleBackColor = true;
            // 
            // btnFinanseZlecenia
            // 
            this.btnFinanseZlecenia.Location = new System.Drawing.Point(610, 201);
            this.btnFinanseZlecenia.Name = "btnFinanseZlecenia";
            this.btnFinanseZlecenia.Size = new System.Drawing.Size(109, 28);
            this.btnFinanseZlecenia.TabIndex = 3;
            this.btnFinanseZlecenia.Text = "Pogląd Finansowy";
            this.btnFinanseZlecenia.UseVisualStyleBackColor = true;
            // 
            // dtgrdZlecenia
            // 
            this.dtgrdZlecenia.AllowUserToAddRows = false;
            this.dtgrdZlecenia.AllowUserToDeleteRows = false;
            this.dtgrdZlecenia.AllowUserToOrderColumns = true;
            this.dtgrdZlecenia.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrdZlecenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdZlecenia.Location = new System.Drawing.Point(12, 12);
            this.dtgrdZlecenia.MultiSelect = false;
            this.dtgrdZlecenia.Name = "dtgrdZlecenia";
            this.dtgrdZlecenia.ReadOnly = true;
            this.dtgrdZlecenia.RowHeadersVisible = false;
            this.dtgrdZlecenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrdZlecenia.Size = new System.Drawing.Size(724, 168);
            this.dtgrdZlecenia.TabIndex = 67;
            this.dtgrdZlecenia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdZespoly_CellContentClick);
            // 
            // MenuZlecenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 242);
            this.Controls.Add(this.dtgrdZlecenia);
            this.Controls.Add(this.btnFinanseZlecenia);
            this.Controls.Add(this.btnDodajZlecenie);
            this.Controls.Add(this.btnEdytujZlecenie);
            this.Name = "MenuZlecenia";
            this.Text = "MenuZlecenia";
            this.Load += new System.EventHandler(this.MenuZlecenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZlecenia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEdytujZlecenie;
        private System.Windows.Forms.Button btnDodajZlecenie;
        private System.Windows.Forms.Button btnFinanseZlecenia;
        private System.Windows.Forms.DataGridView dtgrdZlecenia;
    }
}