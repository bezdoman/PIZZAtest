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
    public partial class NovaOsoba : Form
    {
        public int broj = 1;
        public BindingList<string> Emailovi;
        public BindingList<string> Telefoni;
        public NovaOsoba()
        {
            InitializeComponent();
            Emailovi = new BindingList<string>();
            Telefoni=new BindingList<string>();
            listBoxEmail.DataSource = Emailovi;
            listBoxTelefoni.DataSource = Telefoni;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtUlica.Text != "" && numUDBroj.Value != 0 && txtGrad.Text != "" && txtDrzava.Text != "")
            {
                try
                {
                    ISession s = DataLayer.GetSession();
                    ITransaction t = s.BeginTransaction();
                    Osoba o = new Osoba()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Ulica = txtUlica.Text,
                        Broj = (int)numUDBroj.Value,
                        Grad = txtGrad.Text,
                        Drzava = txtDrzava.Text
                    };
                    s.Save(o);
                    foreach (var email in Emailovi)
                    {
                        Email em = new Email()
                        {
                            EmailKontakt = email,
                            OsobaKontakt = o
                        };
                        s.Save(em);
                        o.Emailovi.Add(em);
                    }

                    foreach (var telefon in Telefoni)
                    {
                        Telefon tel = new Telefon()
                        {
                            OsobaKontakt = o,
                            TelefonKontakt = telefon
                        };
                        s.Save(tel);
                        o.Telefoni.Add(tel);
                    }
                    t.Commit();
                    s.Close();
                    MessageBox.Show("kraj");
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else { MessageBox.Show("Unesite sve podatke!"); }
        }

        private void NovaOsoba_Load(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajEmail_Click(object sender, EventArgs e)
        {
            using (NewEmail noviEmail = new NewEmail())
            {
                if (noviEmail.ShowDialog() == DialogResult.OK)
                {
                    Emailovi.Add(noviEmail.Email);
                }
            }

            
        }

        private void btnDodajTel_Click(object sender, EventArgs e)
        {
            using (NewPhone noviTel=new NewPhone())
            {
                if (noviTel.ShowDialog() == DialogResult.OK)
                {
                    Telefoni.Add(noviTel.Tel);
                }
            }
        }
    }
}
