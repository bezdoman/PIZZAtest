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
    public partial class NewPhone : Form
    {
        public string Tel { get; set; }

        public NewPhone()
        {
            InitializeComponent();
        }

        private void btnTel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Tel = txtBoxTel.Text;
            Close();
        }
    }
}
