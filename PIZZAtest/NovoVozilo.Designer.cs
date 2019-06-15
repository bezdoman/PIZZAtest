namespace PIZZAtest
{
    partial class NovoVozilo
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
            this.listBoxZaposleni = new System.Windows.Forms.ListBox();
            this.radioButtonBicikl = new System.Windows.Forms.RadioButton();
            this.radioButtonSkuter = new System.Windows.Forms.RadioButton();
            this.radioButtonAutomobil = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxSkuAut = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRegistracioniBroj = new System.Windows.Forms.TextBox();
            this.textBoxBrojDozvole = new System.Windows.Forms.TextBox();
            this.textBoxNazivRama = new System.Windows.Forms.TextBox();
            this.textBoxProizvodjac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVelicinaRama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVoziloGod = new System.Windows.Forms.Button();
            this.groupBoxBickl = new System.Windows.Forms.GroupBox();
            this.groupBoxSkuAut.SuspendLayout();
            this.groupBoxBickl.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxZaposleni
            // 
            this.listBoxZaposleni.FormattingEnabled = true;
            this.listBoxZaposleni.Location = new System.Drawing.Point(12, 9);
            this.listBoxZaposleni.Name = "listBoxZaposleni";
            this.listBoxZaposleni.Size = new System.Drawing.Size(240, 329);
            this.listBoxZaposleni.TabIndex = 0;
            // 
            // radioButtonBicikl
            // 
            this.radioButtonBicikl.AutoSize = true;
            this.radioButtonBicikl.Location = new System.Drawing.Point(346, 40);
            this.radioButtonBicikl.Name = "radioButtonBicikl";
            this.radioButtonBicikl.Size = new System.Drawing.Size(50, 17);
            this.radioButtonBicikl.TabIndex = 1;
            this.radioButtonBicikl.TabStop = true;
            this.radioButtonBicikl.Text = "Bicikl";
            this.radioButtonBicikl.UseVisualStyleBackColor = true;
            this.radioButtonBicikl.CheckedChanged += new System.EventHandler(this.radioButtonBicikl_CheckedChanged);
            // 
            // radioButtonSkuter
            // 
            this.radioButtonSkuter.AutoSize = true;
            this.radioButtonSkuter.Location = new System.Drawing.Point(477, 40);
            this.radioButtonSkuter.Name = "radioButtonSkuter";
            this.radioButtonSkuter.Size = new System.Drawing.Size(56, 17);
            this.radioButtonSkuter.TabIndex = 2;
            this.radioButtonSkuter.TabStop = true;
            this.radioButtonSkuter.Text = "Skuter";
            this.radioButtonSkuter.UseVisualStyleBackColor = true;
            this.radioButtonSkuter.CheckedChanged += new System.EventHandler(this.radioButtonSkuter_CheckedChanged);
            // 
            // radioButtonAutomobil
            // 
            this.radioButtonAutomobil.AutoSize = true;
            this.radioButtonAutomobil.Location = new System.Drawing.Point(597, 40);
            this.radioButtonAutomobil.Name = "radioButtonAutomobil";
            this.radioButtonAutomobil.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAutomobil.TabIndex = 3;
            this.radioButtonAutomobil.TabStop = true;
            this.radioButtonAutomobil.Text = "Automobil";
            this.radioButtonAutomobil.UseVisualStyleBackColor = true;
            this.radioButtonAutomobil.CheckedChanged += new System.EventHandler(this.radioButtonAutomobil_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IzaberiteTip";
            // 
            // groupBoxSkuAut
            // 
            this.groupBoxSkuAut.Controls.Add(this.label6);
            this.groupBoxSkuAut.Controls.Add(this.label5);
            this.groupBoxSkuAut.Controls.Add(this.textBoxRegistracioniBroj);
            this.groupBoxSkuAut.Controls.Add(this.textBoxBrojDozvole);
            this.groupBoxSkuAut.Location = new System.Drawing.Point(336, 206);
            this.groupBoxSkuAut.Name = "groupBoxSkuAut";
            this.groupBoxSkuAut.Size = new System.Drawing.Size(403, 80);
            this.groupBoxSkuAut.TabIndex = 5;
            this.groupBoxSkuAut.TabStop = false;
            this.groupBoxSkuAut.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Unesite registracioni broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unesite broj dozvole";
            // 
            // textBoxRegistracioniBroj
            // 
            this.textBoxRegistracioniBroj.Location = new System.Drawing.Point(141, 55);
            this.textBoxRegistracioniBroj.Name = "textBoxRegistracioniBroj";
            this.textBoxRegistracioniBroj.Size = new System.Drawing.Size(256, 20);
            this.textBoxRegistracioniBroj.TabIndex = 2;
            // 
            // textBoxBrojDozvole
            // 
            this.textBoxBrojDozvole.Location = new System.Drawing.Point(141, 23);
            this.textBoxBrojDozvole.Name = "textBoxBrojDozvole";
            this.textBoxBrojDozvole.Size = new System.Drawing.Size(256, 20);
            this.textBoxBrojDozvole.TabIndex = 1;
            // 
            // textBoxNazivRama
            // 
            this.textBoxNazivRama.Location = new System.Drawing.Point(319, 116);
            this.textBoxNazivRama.Name = "textBoxNazivRama";
            this.textBoxNazivRama.Size = new System.Drawing.Size(162, 20);
            this.textBoxNazivRama.TabIndex = 6;
            this.textBoxNazivRama.TextChanged += new System.EventHandler(this.textBoxNazivRama_TextChanged);
            // 
            // textBoxProizvodjac
            // 
            this.textBoxProizvodjac.Location = new System.Drawing.Point(597, 116);
            this.textBoxProizvodjac.Name = "textBoxProizvodjac";
            this.textBoxProizvodjac.Size = new System.Drawing.Size(142, 20);
            this.textBoxProizvodjac.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unesite naziv modela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unesite naziv proizvođača";
            // 
            // textBoxVelicinaRama
            // 
            this.textBoxVelicinaRama.Location = new System.Drawing.Point(134, 26);
            this.textBoxVelicinaRama.Name = "textBoxVelicinaRama";
            this.textBoxVelicinaRama.Size = new System.Drawing.Size(263, 20);
            this.textBoxVelicinaRama.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unesite veličinu rama";
            // 
            // buttonVoziloGod
            // 
            this.buttonVoziloGod.Location = new System.Drawing.Point(477, 303);
            this.buttonVoziloGod.Name = "buttonVoziloGod";
            this.buttonVoziloGod.Size = new System.Drawing.Size(112, 35);
            this.buttonVoziloGod.TabIndex = 10;
            this.buttonVoziloGod.Text = "Dodajte vozilo";
            this.buttonVoziloGod.UseVisualStyleBackColor = true;
            this.buttonVoziloGod.Click += new System.EventHandler(this.buttonVoziloGod_Click);
            // 
            // groupBoxBickl
            // 
            this.groupBoxBickl.Controls.Add(this.label4);
            this.groupBoxBickl.Controls.Add(this.textBoxVelicinaRama);
            this.groupBoxBickl.Location = new System.Drawing.Point(336, 145);
            this.groupBoxBickl.Name = "groupBoxBickl";
            this.groupBoxBickl.Size = new System.Drawing.Size(403, 55);
            this.groupBoxBickl.TabIndex = 11;
            this.groupBoxBickl.TabStop = false;
            this.groupBoxBickl.Text = "groupBox1";
            // 
            // NovoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxBickl);
            this.Controls.Add(this.buttonVoziloGod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProizvodjac);
            this.Controls.Add(this.textBoxNazivRama);
            this.Controls.Add(this.groupBoxSkuAut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonAutomobil);
            this.Controls.Add(this.radioButtonSkuter);
            this.Controls.Add(this.radioButtonBicikl);
            this.Controls.Add(this.listBoxZaposleni);
            this.Name = "NovoVozilo";
            this.Text = "NovoVozilo";
            this.Load += new System.EventHandler(this.NovoVozilo_Load);
            this.groupBoxSkuAut.ResumeLayout(false);
            this.groupBoxSkuAut.PerformLayout();
            this.groupBoxBickl.ResumeLayout(false);
            this.groupBoxBickl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxZaposleni;
        private System.Windows.Forms.RadioButton radioButtonBicikl;
        private System.Windows.Forms.RadioButton radioButtonSkuter;
        private System.Windows.Forms.RadioButton radioButtonAutomobil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSkuAut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRegistracioniBroj;
        private System.Windows.Forms.TextBox textBoxBrojDozvole;
        private System.Windows.Forms.TextBox textBoxNazivRama;
        private System.Windows.Forms.TextBox textBoxProizvodjac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVelicinaRama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVoziloGod;
        private System.Windows.Forms.GroupBox groupBoxBickl;
    }
}