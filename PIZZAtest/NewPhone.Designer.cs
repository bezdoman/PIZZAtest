namespace PIZZAtest
{
    partial class NewPhone
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
            this.btnTel = new System.Windows.Forms.Button();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTel
            // 
            this.btnTel.Location = new System.Drawing.Point(105, 67);
            this.btnTel.Name = "btnTel";
            this.btnTel.Size = new System.Drawing.Size(102, 50);
            this.btnTel.TabIndex = 3;
            this.btnTel.Text = "Dodaj Telefon";
            this.btnTel.UseVisualStyleBackColor = true;
            this.btnTel.Click += new System.EventHandler(this.btnTel_Click);
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(14, 31);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(284, 20);
            this.txtBoxTel.TabIndex = 2;
            // 
            // NewPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 148);
            this.Controls.Add(this.btnTel);
            this.Controls.Add(this.txtBoxTel);
            this.Name = "NewPhone";
            this.Text = "Dodaj novi broj telefona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTel;
        private System.Windows.Forms.TextBox txtBoxTel;
    }
}