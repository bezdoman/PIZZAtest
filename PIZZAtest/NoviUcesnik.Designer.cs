namespace PIZZAtest
{
    partial class NoviUcesnik
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
            this.listKupac = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNoviUcesnik = new System.Windows.Forms.Button();
            this.listUcesnik = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listKupac
            // 
            this.listKupac.FormattingEnabled = true;
            this.listKupac.Location = new System.Drawing.Point(23, 40);
            this.listKupac.Name = "listKupac";
            this.listKupac.Size = new System.Drawing.Size(205, 290);
            this.listKupac.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kupci:";
            // 
            // btnNoviUcesnik
            // 
            this.btnNoviUcesnik.Location = new System.Drawing.Point(253, 176);
            this.btnNoviUcesnik.Name = "btnNoviUcesnik";
            this.btnNoviUcesnik.Size = new System.Drawing.Size(57, 23);
            this.btnNoviUcesnik.TabIndex = 2;
            this.btnNoviUcesnik.Text = "--->";
            this.btnNoviUcesnik.UseVisualStyleBackColor = true;
            this.btnNoviUcesnik.Click += new System.EventHandler(this.btnNoviUcesnik_Click);
            // 
            // listUcesnik
            // 
            this.listUcesnik.FormattingEnabled = true;
            this.listUcesnik.Location = new System.Drawing.Point(342, 40);
            this.listUcesnik.Name = "listUcesnik";
            this.listUcesnik.Size = new System.Drawing.Size(205, 290);
            this.listUcesnik.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ucesnici:";
            // 
            // NoviUcesnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listUcesnik);
            this.Controls.Add(this.btnNoviUcesnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listKupac);
            this.Name = "NoviUcesnik";
            this.Text = "NoviUcesnik";
            this.Load += new System.EventHandler(this.NoviUcesnik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listKupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNoviUcesnik;
        private System.Windows.Forms.ListBox listUcesnik;
        private System.Windows.Forms.Label label2;
    }
}