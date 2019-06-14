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
    public partial class NovaOsoba : Form
    {
        public int broj = 1;
        public NovaOsoba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtUlica.Text != "" && txtBroj.Text != "" && txtGrad.Text != "" && txtDrzava.Text != "")
            {
                //Cuvanje Osobe u bazu
                //
                //
                //
                //
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else { MessageBox.Show("Unesite sve podatke!"); }
        }

        private void NovaOsoba_Load(object sender, EventArgs e)
        {

        }
    }
}
