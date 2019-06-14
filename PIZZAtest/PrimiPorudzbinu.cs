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
        }
        private void UcitajKupce()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Kupac> kupci = s.QueryOver<Kupac>()
                                                //.Where(x => x.Stanje == "Neisporucena")
                                                .List<Kupac>();

                foreach (Kupac kupac in kupci)
                {
                    listBox1.Items.Add(kupac);
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
                    kupac.SakupljeniBodovi = 0;
                    kupac.DatumPrvePorudzbine = DateTime.Now;
                    kupac.LicniBroj = osoba;
                    s.Save(kupac);
                    //MessageBox.Show($"Ime:{osoba.Ime} i prezime:{osoba.Prezime}");
                    s.Close();
                }
            }
        }
    }
}
