namespace PIZZAtest
{
    partial class NoviPoklon
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioPizza = new System.Windows.Forms.RadioButton();
            this.radioPopust = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodeli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(121, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            // 
            // radioPizza
            // 
            this.radioPizza.AutoSize = true;
            this.radioPizza.Location = new System.Drawing.Point(41, 13);
            this.radioPizza.Name = "radioPizza";
            this.radioPizza.Size = new System.Drawing.Size(50, 17);
            this.radioPizza.TabIndex = 1;
            this.radioPizza.TabStop = true;
            this.radioPizza.Text = "Pizza";
            this.radioPizza.UseVisualStyleBackColor = true;
            // 
            // radioPopust
            // 
            this.radioPopust.AutoSize = true;
            this.radioPopust.Location = new System.Drawing.Point(277, 13);
            this.radioPopust.Name = "radioPopust";
            this.radioPopust.Size = new System.Drawing.Size(58, 17);
            this.radioPopust.TabIndex = 2;
            this.radioPopust.TabStop = true;
            this.radioPopust.Text = "Popust";
            this.radioPopust.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bodovi:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(121, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 160);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ucesnici:";
            // 
            // btnDodeli
            // 
            this.btnDodeli.Location = new System.Drawing.Point(121, 331);
            this.btnDodeli.Name = "btnDodeli";
            this.btnDodeli.Size = new System.Drawing.Size(158, 34);
            this.btnDodeli.TabIndex = 6;
            this.btnDodeli.Text = "Dodeli";
            this.btnDodeli.UseVisualStyleBackColor = true;
            this.btnDodeli.Click += new System.EventHandler(this.btnDodeli_Click);
            // 
            // NoviPoklon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 425);
            this.Controls.Add(this.btnDodeli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioPopust);
            this.Controls.Add(this.radioPizza);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "NoviPoklon";
            this.Text = "NoviPoklon";
            this.Load += new System.EventHandler(this.NoviPoklon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioPizza;
        private System.Windows.Forms.RadioButton radioPopust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodeli;
    }
}