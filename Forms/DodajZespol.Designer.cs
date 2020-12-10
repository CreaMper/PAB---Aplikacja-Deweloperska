namespace Aplikacja_deweloperska_2.Forms
{
    partial class DodajZespol
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
            this.inputNazwaZespolu = new System.Windows.Forms.TextBox();
            this.btnDodajZespol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Zespołu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNazwaZespolu
            // 
            this.inputNazwaZespolu.Location = new System.Drawing.Point(101, 3);
            this.inputNazwaZespolu.Name = "inputNazwaZespolu";
            this.inputNazwaZespolu.Size = new System.Drawing.Size(144, 20);
            this.inputNazwaZespolu.TabIndex = 3;
            // 
            // btnDodajZespol
            // 
            this.btnDodajZespol.Location = new System.Drawing.Point(101, 29);
            this.btnDodajZespol.Name = "btnDodajZespol";
            this.btnDodajZespol.Size = new System.Drawing.Size(121, 23);
            this.btnDodajZespol.TabIndex = 4;
            this.btnDodajZespol.Text = "Dodaj Zespol";
            this.btnDodajZespol.UseVisualStyleBackColor = true;
            this.btnDodajZespol.Click += new System.EventHandler(this.btnDodajZespol_Click);
            // 
            // DodajZespol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 62);
            this.Controls.Add(this.btnDodajZespol);
            this.Controls.Add(this.inputNazwaZespolu);
            this.Controls.Add(this.label1);
            this.Name = "DodajZespol";
            this.Text = "DodajZespol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNazwaZespolu;
        private System.Windows.Forms.Button btnDodajZespol;
    }
}