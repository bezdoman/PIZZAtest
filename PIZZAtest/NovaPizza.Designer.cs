namespace PIZZAtest
{
    partial class NovaPizza
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
            this.btnDodajPizzu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPizza = new System.Windows.Forms.TextBox();
            this.txtDodatak = new System.Windows.Forms.TextBox();
            this.btnDodatak = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxDodaci = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajPizzu
            // 
            this.btnDodajPizzu.Location = new System.Drawing.Point(64, 299);
            this.btnDodajPizzu.Name = "btnDodajPizzu";
            this.btnDodajPizzu.Size = new System.Drawing.Size(177, 66);
            this.btnDodajPizzu.TabIndex = 7;
            this.btnDodajPizzu.Text = "Dodaj pizzu";
            this.btnDodajPizzu.UseVisualStyleBackColor = true;
            this.btnDodajPizzu.Click += new System.EventHandler(this.btnDodajPizzu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cena";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(116, 76);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(155, 20);
            this.txtCena.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime pizze";
            // 
            // txtPizza
            // 
            this.txtPizza.Location = new System.Drawing.Point(116, 38);
            this.txtPizza.Name = "txtPizza";
            this.txtPizza.Size = new System.Drawing.Size(155, 20);
            this.txtPizza.TabIndex = 8;
            // 
            // txtDodatak
            // 
            this.txtDodatak.Location = new System.Drawing.Point(20, 45);
            this.txtDodatak.Name = "txtDodatak";
            this.txtDodatak.Size = new System.Drawing.Size(114, 20);
            this.txtDodatak.TabIndex = 10;
            // 
            // btnDodatak
            // 
            this.btnDodatak.Location = new System.Drawing.Point(20, 82);
            this.btnDodatak.Name = "btnDodatak";
            this.btnDodatak.Size = new System.Drawing.Size(114, 43);
            this.btnDodatak.TabIndex = 12;
            this.btnDodatak.Text = "Dodaj dodatak";
            this.btnDodatak.UseVisualStyleBackColor = true;
            this.btnDodatak.Click += new System.EventHandler(this.btnDodatak_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxDodaci);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDodatak);
            this.groupBox1.Controls.Add(this.btnDodatak);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 150);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaci";
            // 
            // listBoxDodaci
            // 
            this.listBoxDodaci.FormattingEnabled = true;
            this.listBoxDodaci.Location = new System.Drawing.Point(184, 16);
            this.listBoxDodaci.Name = "listBoxDodaci";
            this.listBoxDodaci.Size = new System.Drawing.Size(120, 121);
            this.listBoxDodaci.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ime dodatka";
            // 
            // NovaPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPizza);
            this.Controls.Add(this.btnDodajPizzu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCena);
            this.Name = "NovaPizza";
            this.Text = "NovaPizza";
            this.Load += new System.EventHandler(this.NovaPizza_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajPizzu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPizza;
        private System.Windows.Forms.TextBox txtDodatak;
        private System.Windows.Forms.Button btnDodatak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDodaci;
    }
}