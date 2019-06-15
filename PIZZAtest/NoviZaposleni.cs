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
        public List<StraniJezik> jezici;
        int broj;
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

            broj = -1;

        }

        private void btnNovaOsoba_Click(object sender, EventArgs e)
        {
            using (NovaOsoba forma = new NovaOsoba())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    broj = forma.broj;
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
            if (broj != -1)
            {
                ISession sesija = DataLayer.GetSession();
                ITransaction transakcija = sesija.BeginTransaction();
                Osoba osoba = sesija.Load<Osoba>(broj);
                if (radioOperater.Checked)
                {
                    Operater operater = new Operater()
                    {
                        LicniBroj = osoba,
                        DatumRodjenja = dateTimePicker1.Value,
                        JMBG = (int)numericUpDown1.Value
                    };
                    sesija.Save(operater);
                    foreach (StraniJezik jezik in listJezici.Items)
                    {
                        jezik.ZaposleniId = operater;
                        sesija.Save(jezik);
                        operater.Jezici.Add(jezik);
                    }
                    transakcija.Commit();
                }
                else
                {
                    if (comboKategorija.SelectedIndex != -1)
                    {
                        Dostavljac dostavljac = new Dostavljac()
                        {
                            LicniBroj = osoba,
                            DatumRodjenja = dateTimePicker1.Value,
                            JMBG = (int)numericUpDown1.Value,
                            Kategorija = (string)comboKategorija.SelectedValue
                        };
                        sesija.Save(dostavljac);
                        transakcija.Commit();
                    }
                    else
                    {
                        MessageBox.Show("Izaberite kategoriju");
                    }
                }
                sesija.Close();
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("Unesite licne podatke");
            }
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (textJezik.Text != "" && comboNivo.SelectedIndex > -1)
            {
                StraniJezik jezik = new StraniJezik();
                jezik.Jezik = textJezik.Text;
                jezik.Nivo = comboNivo.SelectedItem.ToString();
                listJezici.Items.Add(jezik);
            }
            else {
                MessageBox.Show("Popunite jezik i izaberite nivo");
            }
        }

        private void listJezici_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
