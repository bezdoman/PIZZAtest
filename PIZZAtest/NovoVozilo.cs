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
    public partial class NovoVozilo : Form
    {
        IList<Dostavljac> dostavljac;
        public NovoVozilo()
        {
            InitializeComponent();
            groupBoxSkuAut.Hide();
            groupBoxBickl.Hide();
        }

        public void ucitajZaposlene(string kategorija) {
            try
            {
                ISession session = DataLayer.GetSession();
                if (kategorija != "bicikl")
                {
                    dostavljac = session.QueryOver<Dostavljac>()
                                    .Where(x => x.Kategorija == kategorija)
                                    .List<Dostavljac>();
                    foreach (Dostavljac d in dostavljac) {
                        listBoxZaposleni.Items.Add(d);
                    }
                }
                else
                {
                    dostavljac = session.QueryOver<Dostavljac>()
                                    .List<Dostavljac>();
                    foreach (Dostavljac d in dostavljac) {
                        listBoxZaposleni.Items.Add(d);
                    }
                }
                session.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void radioButtonBicikl_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBicikl.Checked)
            {
                groupBoxSkuAut.Hide();
                listBoxZaposleni.Items.Clear();
                groupBoxBickl.Visible = true;
                ucitajZaposlene("bicikl");
            }
        }

        private void NovoVozilo_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonSkuter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSkuter.Checked)
            {
                groupBoxBickl.Hide();
                listBoxZaposleni.Items.Clear();
                groupBoxSkuAut.Visible = true;
                ucitajZaposlene("C");
                
            }
        }

        private void radioButtonAutomobil_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAutomobil.Checked)
            {
                groupBoxBickl.Hide();
                listBoxZaposleni.Items.Clear();
                groupBoxSkuAut.Visible = true;
                ucitajZaposlene("B");
            }
        }

        private void textBoxNazivRama_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVoziloGod_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            ITransaction transakcija = session.BeginTransaction();
            if (radioButtonBicikl.Checked)
            {
                //naziv rama je naziv modela greska u imenovanju
                if (textBoxNazivRama.Text != "" && textBoxProizvodjac.Text != "" && textBoxVelicinaRama.Text != ""&& listBoxZaposleni.SelectedIndex != -1)
                {
                    Bicikl vozilo = new Bicikl();
                    vozilo.Model = textBoxNazivRama.Text;
                    vozilo.Proizvodjac = textBoxProizvodjac.Text;
                    vozilo.Ram = int.Parse(textBoxVelicinaRama.Text);
                     //    vozilo.IdZaposleni = null;
                        //}
                        //else
                        //{
                        //Mapiranje ovo samo radi
                        Dostavljac dostavljac = session.Load<Dostavljac>(((Dostavljac)listBoxZaposleni.SelectedItem).Id);
                        vozilo.IdZaposleni = dostavljac;
                        session.Save(vozilo);
                        dostavljac.Vozila.Add(vozilo);
                        transakcija.Commit();
                    
                    //session.Save(vozilo);
                    //transakcija.Commit();
                    
                }
                else
                {
                    MessageBox.Show("Unesite sve podatke!");
                }
            }
            else if (radioButtonSkuter.Checked)
            {
                if (textBoxNazivRama.Text != "" && textBoxProizvodjac.Text != "" && textBoxBrojDozvole.Text != "" && textBoxRegistracioniBroj.Text != ""&& listBoxZaposleni.SelectedIndex != -1)
                {
                    Skuter skuter = new Skuter();
                    skuter.Model = textBoxNazivRama.Text;
                    skuter.Proizvodjac = textBoxProizvodjac.Text;
                    skuter.Registracija = textBoxRegistracioniBroj.Text;
                    skuter.Dozvola = int.Parse(textBoxBrojDozvole.Text);
                    if (listBoxZaposleni.SelectedIndex != -1)
                    {
                        Dostavljac dostavljac = session.Load<Dostavljac>(((Dostavljac)listBoxZaposleni.SelectedItem).Id);
                        skuter.IdZaposleni = dostavljac;
                        session.Save(skuter);
                        dostavljac.Vozila.Add(skuter);
                        transakcija.Commit();
                    }
                    else
                    {
                        session.Save(skuter);
                        transakcija.Commit();
                    }
                }

                else
                {
                    MessageBox.Show("Unesite sve podatke!");
                }
            }
            else if (radioButtonAutomobil.Checked)
            {
                if (textBoxNazivRama.Text != "" && textBoxProizvodjac.Text != "" && textBoxBrojDozvole.Text != "" && textBoxRegistracioniBroj.Text != ""&&listBoxZaposleni.SelectedIndex != -1)
                {
                    Automobil skuter = new Automobil();
                    skuter.Model = textBoxNazivRama.Text;
                    skuter.Proizvodjac = textBoxProizvodjac.Text;
                    skuter.Registracija = textBoxRegistracioniBroj.Text;
                    skuter.Dozvola = int.Parse(textBoxBrojDozvole.Text);
                    if (listBoxZaposleni.SelectedIndex != -1)
                    {
                        Dostavljac dostavljac = session.Load<Dostavljac>(((Dostavljac)listBoxZaposleni.SelectedItem).Id);
                        skuter.IdZaposleni = dostavljac;
                        session.Save(skuter);
                        dostavljac.Vozila.Add(skuter);
                        transakcija.Commit();
                    }
                    else
                    {
                        session.Save(skuter);
                        transakcija.Commit();
                    }
                }
                else
                {
                    MessageBox.Show("Unesite sve podatke!");
                }
            }
            else {
                MessageBox.Show("Izaberite tip vozila koji ubacujete");
            }
            session.Close();
            this.Close();
        }
    }
}
