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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPizza = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.comboVelicina = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listSadrzaj = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNoviKupac
            // 
            this.btnNoviKupac.Location = new System.Drawing.Point(226, 308);
            this.btnNoviKupac.Name = "btnNoviKupac";
            this.btnNoviKupac.Size = new System.Drawing.Size(185, 23);
            this.btnNoviKupac.TabIndex = 0;
            this.btnNoviKupac.Text = "Novi Kupac";
            this.btnNoviKupac.UseVisualStyleBackColor = true;
            this.btnNoviKupac.Click += new System.EventHandler(this.btnNoviKupac_Click);
            // 
            // listKupac
            // 
            this.listKupac.FormattingEnabled = true;
            this.listKupac.Location = new System.Drawing.Point(226, 12);
            this.listKupac.Name = "listKupac";
            this.listKupac.Size = new System.Drawing.Size(185, 290);
            this.listKupac.TabIndex = 2;
            // 
            // listOperater
            // 
            this.listOperater.FormattingEnabled = true;
            this.listOperater.Location = new System.Drawing.Point(12, 12);
            this.listOperater.Name = "listOperater";
            this.listOperater.Size = new System.Drawing.Size(185, 290);
            this.listOperater.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(507, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
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
            this.comboPizza.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listSadrzaj
            // 
            this.listSadrzaj.FormattingEnabled = true;
            this.listSadrzaj.Location = new System.Drawing.Point(6, 185);
            this.listSadrzaj.Name = "listSadrzaj";
            this.listSadrzaj.Size = new System.Drawing.Size(202, 95);
            this.listSadrzaj.TabIndex = 8;
            // 
            // PrimiPorudzbinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listOperater);
            this.Controls.Add(this.listKupac);
            this.Controls.Add(this.btnNoviKupac);
            this.Name = "PrimiPorudzbinu";
            this.Text = "PrimiPorudzbinu";
            this.Load += new System.EventHandler(this.PrimiPorudzbinu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoviKupac;
        private System.Windows.Forms.ListBox listKupac;
        private System.Windows.Forms.ListBox listOperater;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboVelicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listSadrzaj;
    }
}