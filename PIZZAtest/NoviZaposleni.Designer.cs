namespace PIZZAtest
{
    partial class NoviZaposleni
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
            this.btnNovaOsoba = new System.Windows.Forms.Button();
            this.radioOperater = new System.Windows.Forms.RadioButton();
            this.radioDostavljac = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboKategorija = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupDostavljac = new System.Windows.Forms.GroupBox();
            this.listJezici = new System.Windows.Forms.ListBox();
            this.groupOperater = new System.Windows.Forms.GroupBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.textJezik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboNivo = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.groupDostavljac.SuspendLayout();
            this.groupOperater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaOsoba
            // 
            this.btnNovaOsoba.Location = new System.Drawing.Point(139, 12);
            this.btnNovaOsoba.Name = "btnNovaOsoba";
            this.btnNovaOsoba.Size = new System.Drawing.Size(200, 23);
            this.btnNovaOsoba.TabIndex = 0;
            this.btnNovaOsoba.Text = "Lični Podaci";
            this.btnNovaOsoba.UseVisualStyleBackColor = true;
            this.btnNovaOsoba.Click += new System.EventHandler(this.btnNovaOsoba_Click);
            // 
            // radioOperater
            // 
            this.radioOperater.AutoSize = true;
            this.radioOperater.Location = new System.Drawing.Point(41, 175);
            this.radioOperater.Name = "radioOperater";
            this.radioOperater.Size = new System.Drawing.Size(66, 17);
            this.radioOperater.TabIndex = 0;
            this.radioOperater.TabStop = true;
            this.radioOperater.Text = "Operater";
            this.radioOperater.UseVisualStyleBackColor = true;
            this.radioOperater.CheckedChanged += new System.EventHandler(this.radioOperater_CheckedChanged);
            // 
            // radioDostavljac
            // 
            this.radioDostavljac.AutoSize = true;
            this.radioDostavljac.Location = new System.Drawing.Point(276, 175);
            this.radioDostavljac.Name = "radioDostavljac";
            this.radioDostavljac.Size = new System.Drawing.Size(75, 17);
            this.radioDostavljac.TabIndex = 1;
            this.radioDostavljac.TabStop = true;
            this.radioDostavljac.Text = "Dostavljac";
            this.radioDostavljac.UseVisualStyleBackColor = true;
            this.radioDostavljac.CheckedChanged += new System.EventHandler(this.radioDostavljac_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum rođenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "JMBG:";
            // 
            // comboKategorija
            // 
            this.comboKategorija.FormattingEnabled = true;
            this.comboKategorija.Location = new System.Drawing.Point(73, 30);
            this.comboKategorija.Name = "comboKategorija";
            this.comboKategorija.Size = new System.Drawing.Size(93, 21);
            this.comboKategorija.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategorija:";
            // 
            // groupDostavljac
            // 
            this.groupDostavljac.Controls.Add(this.label3);
            this.groupDostavljac.Controls.Add(this.comboKategorija);
            this.groupDostavljac.Location = new System.Drawing.Point(236, 210);
            this.groupDostavljac.Name = "groupDostavljac";
            this.groupDostavljac.Size = new System.Drawing.Size(182, 58);
            this.groupDostavljac.TabIndex = 8;
            this.groupDostavljac.TabStop = false;
            // 
            // listJezici
            // 
            this.listJezici.FormattingEnabled = true;
            this.listJezici.Location = new System.Drawing.Point(85, 95);
            this.listJezici.Name = "listJezici";
            this.listJezici.Size = new System.Drawing.Size(120, 95);
            this.listJezici.TabIndex = 9;
            this.listJezici.SelectedIndexChanged += new System.EventHandler(this.listJezici_SelectedIndexChanged);
            // 
            // groupOperater
            // 
            this.groupOperater.Controls.Add(this.btnDodaj);
            this.groupOperater.Controls.Add(this.textJezik);
            this.groupOperater.Controls.Add(this.label5);
            this.groupOperater.Controls.Add(this.listJezici);
            this.groupOperater.Controls.Add(this.label4);
            this.groupOperater.Controls.Add(this.comboNivo);
            this.groupOperater.Location = new System.Drawing.Point(8, 210);
            this.groupOperater.Name = "groupOperater";
            this.groupOperater.Size = new System.Drawing.Size(222, 213);
            this.groupOperater.TabIndex = 10;
            this.groupOperater.TabStop = false;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(8, 95);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(71, 23);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj -->";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // textJezik
            // 
            this.textJezik.Location = new System.Drawing.Point(84, 12);
            this.textJezik.Name = "textJezik";
            this.textJezik.Size = new System.Drawing.Size(121, 20);
            this.textJezik.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jezik:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nivo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboNivo
            // 
            this.comboNivo.FormattingEnabled = true;
            this.comboNivo.Location = new System.Drawing.Point(84, 57);
            this.comboNivo.Name = "comboNivo";
            this.comboNivo.Size = new System.Drawing.Size(121, 21);
            this.comboNivo.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 120);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(148, 429);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(148, 46);
            this.btnPotvrdi.TabIndex = 12;
            this.btnPotvrdi.Text = "POTVRDI";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoviZaposleni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 487);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupOperater);
            this.Controls.Add(this.radioDostavljac);
            this.Controls.Add(this.groupDostavljac);
            this.Controls.Add(this.radioOperater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnNovaOsoba);
            this.Name = "NoviZaposleni";
            this.Text = "NoviZaposleni";
            this.Load += new System.EventHandler(this.NoviZaposleni_Load);
            this.groupDostavljac.ResumeLayout(false);
            this.groupDostavljac.PerformLayout();
            this.groupOperater.ResumeLayout(false);
            this.groupOperater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaOsoba;
        private System.Windows.Forms.RadioButton radioDostavljac;
        private System.Windows.Forms.RadioButton radioOperater;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboKategorija;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupDostavljac;
        private System.Windows.Forms.ListBox listJezici;
        private System.Windows.Forms.GroupBox groupOperater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboNivo;
        private System.Windows.Forms.TextBox textJezik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnDodaj;
    }
}