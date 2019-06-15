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
        public NovoVozilo()
        {
            InitializeComponent();
            groupBoxSkuAut.Hide();
            groupBoxBickl.Hide();
        }

        public IList<Dostavljac> ucitajZaposlene(string kategorija) {
            try
            {
                ISession session = DataLayer.GetSession();
                IList<Dostavljac> dostavljacs;
                if (kategorija != "bicikl")
                {
                    dostavljacs = session.QueryOver<Dostavljac>()
                                    .Where(x => x.Kategorija == kategorija)
                                    .List<Dostavljac>();
                }
                else
                {
                    dostavljacs = session.QueryOver<Dostavljac>()
                                    .List<Dostavljac>();
                }
                session.Close();
                return dostavljacs;
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
                return null;
            }
        }

        private void radioButtonBicikl_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBicikl.Checked)
            {
                listBoxZaposleni.Items.Clear();
                groupBoxBickl.Visible = true;
                IList<Dostavljac> dostavljac = ucitajZaposlene("bicikl");
                foreach (Dostavljac d in dostavljac)
                {
                    listBoxZaposleni.Items.Add(d);
                }
            }
        }

        private void NovoVozilo_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonSkuter_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSkuter.Checked)
            {
                listBoxZaposleni.Items.Clear();
                groupBoxSkuAut.Visible = true;
                IList<Dostavljac> dostavljac = ucitajZaposlene("C");
                foreach (Dostavljac d in dostavljac)
                {
                    listBoxZaposleni.Items.Add(d);
                }
            }
        }

        private void radioButtonAutomobil_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAutomobil.Checked)
            {
                listBoxZaposleni.Items.Clear();
                groupBoxSkuAut.Visible = true;
                IList<Dostavljac> dostavljac = ucitajZaposlene("B");
                foreach (Dostavljac d in dostavljac)
                {
                    listBoxZaposleni.Items.Add(d);
                }
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
                if (textBoxNazivRama.Text != "" && textBoxProizvodjac.Text != "" && textBoxVelicinaRama.Text != "")
                {
                    Bicikl vozilo = new Bicikl();
                    vozilo.Model = textBoxNazivRama.Text;
                    vozilo.Proizvodjac = textBoxProizvodjac.Text;
                    vozilo.Ram = int.Parse(textBoxVelicinaRama.Text);
                    if (listBoxZaposleni.SelectedIndex != -1)
                    {
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
                    }
                    //session.Save(vozilo);
                    //transakcija.Commit();
                    else
                    {
                        session.Save(vozilo);
                        transakcija.Commit();
                    }
                }
                else
                {
                    MessageBox.Show("Unesite sve podatke!");
                }
            }
            else if (radioButtonSkuter.Checked)
            {
                if (textBoxNazivRama.Text != "" && textBoxProizvodjac.Text != "" && textBoxBrojDozvole.Text != "" && textBoxRegistracioniBroj.Text != "")
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
                if (textBoxNazivRama.Text != "" && textBoxProizvodjac.Text != "" && textBoxBrojDozvole.Text != "" && textBoxRegistracioniBroj.Text != "")
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
