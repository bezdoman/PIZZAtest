namespace PIZZAtest
{
    partial class Isporuci
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
            this.listPorudzbina = new System.Windows.Forms.ListBox();
            this.listDostavljac = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listVozilo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPorudzbina
            // 
            this.listPorudzbina.FormattingEnabled = true;
            this.listPorudzbina.Location = new System.Drawing.Point(29, 51);
            this.listPorudzbina.Name = "listPorudzbina";
            this.listPorudzbina.Size = new System.Drawing.Size(201, 303);
            this.listPorudzbina.TabIndex = 0;
            this.listPorudzbina.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listDostavljac
            // 
            this.listDostavljac.FormattingEnabled = true;
            this.listDostavljac.Location = new System.Drawing.Point(250, 51);
            this.listDostavljac.Name = "listDostavljac";
            this.listDostavljac.Size = new System.Drawing.Size(164, 303);
            this.listDostavljac.TabIndex = 1;
            this.listDostavljac.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Porudzbine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dostavljaci:";
            // 
            // listVozilo
            // 
            this.listVozilo.FormattingEnabled = true;
            this.listVozilo.Location = new System.Drawing.Point(434, 51);
            this.listVozilo.Name = "listVozilo";
            this.listVozilo.Size = new System.Drawing.Size(164, 303);
            this.listVozilo.TabIndex = 4;
            this.listVozilo.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vozila:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(315, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Isporuci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Isporuci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listVozilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listDostavljac);
            this.Controls.Add(this.listPorudzbina);
            this.Name = "Isporuci";
            this.Text = "Isporuci";
            this.Load += new System.EventHandler(this.Isporuci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPorudzbina;
        private System.Windows.Forms.ListBox listDostavljac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listVozilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}