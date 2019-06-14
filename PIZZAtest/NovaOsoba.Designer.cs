namespace PIZZAtest
{
    partial class NovaOsoba
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtUlica = new System.Windows.Forms.TextBox();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numUDBroj = new System.Windows.Forms.NumericUpDown();
            this.listBoxEmail = new System.Windows.Forms.ListBox();
            this.btnDodajEmail = new System.Windows.Forms.Button();
            this.label7fa = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxTelefoni = new System.Windows.Forms.ListBox();
            this.btnDodajTel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDBroj)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(117, 8);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(117, 34);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 2;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtUlica
            // 
            this.txtUlica.Location = new System.Drawing.Point(117, 60);
            this.txtUlica.Name = "txtUlica";
            this.txtUlica.Size = new System.Drawing.Size(100, 20);
            this.txtUlica.TabIndex = 3;
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(117, 112);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(100, 20);
            this.txtGrad.TabIndex = 5;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(117, 138);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(100, 20);
            this.txtDrzava.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ulica:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Drzava:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numUDBroj
            // 
            this.numUDBroj.Location = new System.Drawing.Point(117, 86);
            this.numUDBroj.Name = "numUDBroj";
            this.numUDBroj.Size = new System.Drawing.Size(100, 20);
            this.numUDBroj.TabIndex = 13;
            // 
            // listBoxEmail
            // 
            this.listBoxEmail.FormattingEnabled = true;
            this.listBoxEmail.Location = new System.Drawing.Point(12, 192);
            this.listBoxEmail.Name = "listBoxEmail";
            this.listBoxEmail.Size = new System.Drawing.Size(205, 43);
            this.listBoxEmail.TabIndex = 14;
            // 
            // btnDodajEmail
            // 
            this.btnDodajEmail.Location = new System.Drawing.Point(223, 192);
            this.btnDodajEmail.Name = "btnDodajEmail";
            this.btnDodajEmail.Size = new System.Drawing.Size(53, 43);
            this.btnDodajEmail.TabIndex = 15;
            this.btnDodajEmail.Text = "Dodaj";
            this.btnDodajEmail.UseVisualStyleBackColor = true;
            this.btnDodajEmail.Click += new System.EventHandler(this.btnDodajEmail_Click);
            // 
            // label7fa
            // 
            this.label7fa.AutoSize = true;
            this.label7fa.Location = new System.Drawing.Point(9, 176);
            this.label7fa.Name = "label7fa";
            this.label7fa.Size = new System.Drawing.Size(49, 13);
            this.label7fa.TabIndex = 16;
            this.label7fa.Text = "Emailovi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefoni:";
            // 
            // listBoxTelefoni
            // 
            this.listBoxTelefoni.FormattingEnabled = true;
            this.listBoxTelefoni.Location = new System.Drawing.Point(12, 261);
            this.listBoxTelefoni.Name = "listBoxTelefoni";
            this.listBoxTelefoni.Size = new System.Drawing.Size(205, 43);
            this.listBoxTelefoni.TabIndex = 17;
            // 
            // btnDodajTel
            // 
            this.btnDodajTel.Location = new System.Drawing.Point(223, 261);
            this.btnDodajTel.Name = "btnDodajTel";
            this.btnDodajTel.Size = new System.Drawing.Size(53, 43);
            this.btnDodajTel.TabIndex = 21;
            this.btnDodajTel.Text = "Dodaj";
            this.btnDodajTel.UseVisualStyleBackColor = true;
            this.btnDodajTel.Click += new System.EventHandler(this.btnDodajTel_Click);
            // 
            // NovaOsoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 381);
            this.Controls.Add(this.btnDodajTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxTelefoni);
            this.Controls.Add(this.label7fa);
            this.Controls.Add(this.btnDodajEmail);
            this.Controls.Add(this.listBoxEmail);
            this.Controls.Add(this.numUDBroj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDrzava);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.txtUlica);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Name = "NovaOsoba";
            this.Text = "NovaOsoba";
            this.Load += new System.EventHandler(this.NovaOsoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDBroj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtUlica;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numUDBroj;
        private System.Windows.Forms.ListBox listBoxEmail;
        private System.Windows.Forms.Button btnDodajEmail;
        private System.Windows.Forms.Label label7fa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxTelefoni;
        private System.Windows.Forms.Button btnDodajTel;
    }
}