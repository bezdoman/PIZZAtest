using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using PIZZAtest.Entiteti;

namespace PIZZAtest
{
    public partial class NoviZaposleni : Form
    {
        public NoviZaposleni()
        {
            InitializeComponent();

            Start();
        }

        private void Start()
        {
            comboKategorija.Items.Add("AM");
            comboKategorija.Items.Add("A1");
            comboKategorija.Items.Add("A2");
            comboKategorija.Items.Add("A");
            comboKategorija.Items.Add("B1");
            comboKategorija.Items.Add("B");
            comboKategorija.Items.Add("BE");
            comboKategorija.Items.Add("C1");
            comboKategorija.Items.Add("C1E");
            comboKategorija.Items.Add("C");
            comboKategorija.Items.Add("CE");
            comboKategorija.Items.Add("D1");
            comboKategorija.Items.Add("D1E");
            comboKategorija.Items.Add("D");
            comboKategorija.Items.Add("DE");
            comboKategorija.Items.Add("F");
            comboKategorija.Items.Add("M");

            comboNivo.Items.Add("A1");
            comboNivo.Items.Add("A2");
            comboNivo.Items.Add("B1");
            comboNivo.Items.Add("B2");
            comboNivo.Items.Add("C1");
            comboNivo.Items.Add("C2");

            radioOperater.Checked = false;
            radioDostavljac.Checked = false;
            groupDostavljac.Enabled = false;
            groupOperater.Enabled = false;

        }

        private void btnNovaOsoba_Click(object sender, EventArgs e)
        {
            using (NovaOsoba forma = new NovaOsoba())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    Osoba osoba = s.Load<Osoba>(forma.broj);
                   
                    s.Close();
                }
            }
        }

        private void NoviZaposleni_Load(object sender, EventArgs e)
        {

        }

        private void radioOperater_CheckedChanged(object sender, EventArgs e)
        {
            groupOperater.Enabled = radioOperater.Checked;
        }

        private void radioDostavljac_CheckedChanged(object sender, EventArgs e)
        {
            groupDostavljac.Enabled = radioDostavljac.Checked;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
