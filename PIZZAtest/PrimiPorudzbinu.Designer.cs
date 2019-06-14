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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnNoviKupac
            // 
            this.btnNoviKupac.Location = new System.Drawing.Point(54, 321);
            this.btnNoviKupac.Name = "btnNoviKupac";
            this.btnNoviKupac.Size = new System.Drawing.Size(96, 23);
            this.btnNoviKupac.TabIndex = 0;
            this.btnNoviKupac.Text = "Novi Kupac";
            this.btnNoviKupac.UseVisualStyleBackColor = true;
            this.btnNoviKupac.Click += new System.EventHandler(this.btnNoviKupac_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 290);
            this.listBox1.TabIndex = 2;
            // 
            // PrimiPorudzbinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 369);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNoviKupac);
            this.Name = "PrimiPorudzbinu";
            this.Text = "PrimiPorudzbinu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoviKupac;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}