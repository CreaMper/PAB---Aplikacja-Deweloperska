namespace Aplikacja_deweloperska_2.Forms
{
    partial class EdytujZespol
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
            this.btnEdytujZespol = new System.Windows.Forms.Button();
            this.inputNazwaZespolu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdytujZespol
            // 
            this.btnEdytujZespol.Location = new System.Drawing.Point(98, 34);
            this.btnEdytujZespol.Name = "btnEdytujZespol";
            this.btnEdytujZespol.Size = new System.Drawing.Size(121, 23);
            this.btnEdytujZespol.TabIndex = 7;
            this.btnEdytujZespol.Text = "EdytujZespol";
            this.btnEdytujZespol.UseVisualStyleBackColor = true;
            this.btnEdytujZespol.Click += new System.EventHandler(this.btnEdytujZespol_Click);
            // 
            // inputNazwaZespolu
            // 
            this.inputNazwaZespolu.Location = new System.Drawing.Point(98, 8);
            this.inputNazwaZespolu.Name = "inputNazwaZespolu";
            this.inputNazwaZespolu.Size = new System.Drawing.Size(144, 20);
            this.inputNazwaZespolu.TabIndex = 6;
            this.inputNazwaZespolu.TextChanged += new System.EventHandler(this.inputNazwaZespolu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa Zespołu";
            // 
            // EdytujZespol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 72);
            this.Controls.Add(this.btnEdytujZespol);
            this.Controls.Add(this.inputNazwaZespolu);
            this.Controls.Add(this.label1);
            this.Name = "EdytujZespol";
            this.Text = "EdytujZespol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdytujZespol;
        private System.Windows.Forms.TextBox inputNazwaZespolu;
        private System.Windows.Forms.Label label1;
    }
}