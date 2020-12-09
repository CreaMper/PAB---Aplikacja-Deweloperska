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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZespoly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 266);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 153);
            this.dataGridView1.TabIndex = 67;
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
            // ModyfikujZespoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtgrdZespoly);
            this.Controls.Add(this.lblZespoly);
            this.Controls.Add(this.cboZespoly);
            this.Name = "ModyfikujZespoly";
            this.Text = "ModyfikujZespoly";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdZespoly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdZespoly;
        private System.Windows.Forms.Label lblZespoly;
        private System.Windows.Forms.ComboBox cboZespoly;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}