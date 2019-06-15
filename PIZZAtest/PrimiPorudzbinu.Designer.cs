namespace PIZZAtest
{
    partial class PrimiPorudzbinu
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
            this.btnNoviKupac = new System.Windows.Forms.Button();
            this.listKupac = new System.Windows.Forms.ListBox();
            this.listOperater = new System.Windows.Forms.ListBox();
            this.comboNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPizza = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listSadrzaj = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.comboVelicina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrimiPorudzibnu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNoviKupac
            // 
            this.btnNoviKupac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviKupac.Location = new System.Drawing.Point(226, 335);
            this.btnNoviKupac.Name = "btnNoviKupac";
            this.btnNoviKupac.Size = new System.Drawing.Size(185, 28);
            this.btnNoviKupac.TabIndex = 0;
            this.btnNoviKupac.Text = "Novi Kupac";
            this.btnNoviKupac.UseVisualStyleBackColor = true;
            this.btnNoviKupac.Click += new System.EventHandler(this.btnNoviKupac_Click);
            // 
            // listKupac
            // 
            this.listKupac.FormattingEnabled = true;
            this.listKupac.Location = new System.Drawing.Point(226, 39);
            this.listKupac.Name = "listKupac";
            this.listKupac.Size = new System.Drawing.Size(185, 290);
            this.listKupac.TabIndex = 2;
            // 
            // listOperater
            // 
            this.listOperater.FormattingEnabled = true;
            this.listOperater.Location = new System.Drawing.Point(12, 39);
            this.listOperater.Name = "listOperater";
            this.listOperater.Size = new System.Drawing.Size(185, 290);
            this.listOperater.TabIndex = 3;
            // 
            // comboNacinPlacanja
            // 
            this.comboNacinPlacanja.FormattingEnabled = true;
            this.comboNacinPlacanja.Location = new System.Drawing.Point(507, 12);
            this.comboNacinPlacanja.Name = "comboNacinPlacanja";
            this.comboNacinPlacanja.Size = new System.Drawing.Size(121, 21);
            this.comboNacinPlacanja.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nacin placanja";
            // 
            // comboPizza
            // 
            this.comboPizza.FormattingEnabled = true;
            this.comboPizza.Location = new System.Drawing.Point(73, 40);
            this.comboPizza.Name = "comboPizza";
            this.comboPizza.Size = new System.Drawing.Size(121, 21);
            this.comboPizza.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSadrzaj);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.comboVelicina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboPizza);
            this.groupBox1.Location = new System.Drawing.Point(417, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 302);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sadrzaj porudzbine";
            // 
            // listSadrzaj
            // 
            this.listSadrzaj.FormattingEnabled = true;
            this.listSadrzaj.Location = new System.Drawing.Point(6, 185);
            this.listSadrzaj.Name = "listSadrzaj";
            this.listSadrzaj.Size = new System.Drawing.Size(202, 95);
            this.listSadrzaj.TabIndex = 8;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(73, 147);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // comboVelicina
            // 
            this.comboVelicina.FormattingEnabled = true;
            this.comboVelicina.Location = new System.Drawing.Point(73, 88);
            this.comboVelicina.Name = "comboVelicina";
            this.comboVelicina.Size = new System.Drawing.Size(121, 21);
            this.comboVelicina.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Velicina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime pice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Operateri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kupci:";
            // 
            // btnPrimiPorudzibnu
            // 
            this.btnPrimiPorudzibnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimiPorudzibnu.Location = new System.Drawing.Point(155, 385);
            this.btnPrimiPorudzibnu.Name = "btnPrimiPorudzibnu";
            this.btnPrimiPorudzibnu.Size = new System.Drawing.Size(346, 80);
            this.btnPrimiPorudzibnu.TabIndex = 10;
            this.btnPrimiPorudzibnu.Text = "Primi Porudzbinu";
            this.btnPrimiPorudzibnu.UseVisualStyleBackColor = true;
            this.btnPrimiPorudzibnu.Click += new System.EventHandler(this.btnPrimiPorudzibnu_Click);
            // 
            // PrimiPorudzbinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 515);
            this.Controls.Add(this.btnPrimiPorudzibnu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboNacinPlacanja);
            this.Controls.Add(this.listOperater);
            this.Controls.Add(this.listKupac);
            this.Controls.Add(this.btnNoviKupac);
            this.Name = "PrimiPorudzbinu";
            this.Text = "PrimiPorudzbinu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoviKupac;
        private System.Windows.Forms.ListBox listKupac;
        private System.Windows.Forms.ListBox listOperater;
        private System.Windows.Forms.ComboBox comboNacinPlacanja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboVelicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listSadrzaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrimiPorudzibnu;
    }
}