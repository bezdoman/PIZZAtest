using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZAtest
{
    public partial class NewEmail : Form
    {
        public string Email { get; set; }

        public NewEmail()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Email = txtBoxEmail.Text;
            Close();
        }
    }
}
