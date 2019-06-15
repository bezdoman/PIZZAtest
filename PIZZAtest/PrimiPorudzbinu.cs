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
    public partial class PrimiPorudzbinu : Form
    {
        public PrimiPorudzbinu()
        {
            InitializeComponent();

            Start();

            UcitajKupce();

            UcitajOperatere();

        }

        private void UcitajOperatere()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Operater> operateri = s.QueryOver<Operater>()
                    .List<Operater>();

                foreach (Operater operater in operateri)
                {
                    operater.LicniBroj = s.QueryOver<Osoba>().Where(x=>x.Id==operater.LicniBroj.Id).List<Osoba>()[0];

                    listOperater.Items.Add(operater);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void Start() {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Pizza> pizze = s.QueryOver<Pizza>().List<Pizza>();

                foreach (Pizza pizza in pizze)
                {
                    comboPizza.Items.Add(pizza);
                }

                IList<VelicinaPizze> velicine = s.QueryOver<VelicinaPizze>().List<VelicinaPizze>();

                foreach (VelicinaPizze velicina in velicine)
                {
                    comboVelicina.Items.Add(velicina);
                }

                s.Close();
                
                List<string> placanje=new List<string>();
                placanje.Add("KARTICA");
                placanje.Add("KES");
                comboNacinPlacanja.DataSource = placanje;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void UcitajKupce()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Kupac> kupci = s.QueryOver<Kupac>().List<Kupac>();

                foreach (Kupac kupac in kupci)
                {
                    kupac.LicniBroj = s.QueryOver<Osoba>().Where(x => x.Id == kupac.LicniBroj.Id).List<Osoba>()[0];
                    listKupac.Items.Add(kupac);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void btnNoviKupac_Click(object sender, EventArgs e)
        {
            using (NovaOsoba forma = new NovaOsoba())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    Osoba osoba = s.Load<Osoba>(forma.broj);
                    Kupac kupac = new Kupac() { };
                 //   kupac.SakupljeniBodovi = 0;
                    kupac.DatumPrvePorudzbine = DateTime.Now;
                    kupac.LicniBroj = osoba;
                    s.Save(kupac);
                    //MessageBox.Show($"Ime:{osoba.Ime} i prezime:{osoba.Prezime}");
                    s.Close();

                    UcitajKupce();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrimiPorudzbinu_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
