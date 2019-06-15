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
    public partial class NoviUcesnik : Form
    {
        public NoviUcesnik()
        {
            InitializeComponent();

            UcitajKupce();

            UcitajUcesnike();
        }
        private void UcitajKupce()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery sqlQuery = s.CreateSQLQuery("SELECT * FROM KUPAC WHERE UCESNIK_FLAG = 'NE'").AddEntity(typeof(Kupac));
                var kupci = sqlQuery.List<Kupac>();

                //IList<Kupac> kupci = s.QueryOver<Kupac>()
                //                                //.Where(x => x.Flag == "NE")
                //                                .List<Kupac>();



                foreach (Kupac kupac in kupci)
                {
                    listKupac.Items.Add(kupac);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void UcitajUcesnike()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Ucesnik> ucesnici = s.QueryOver<Ucesnik>()
                                                //.Where(x=>x.Kategorija=="B")
                                                .List<Ucesnik>();



                foreach (Ucesnik ucesnik in ucesnici)
                {
                    listUcesnik.Items.Add(ucesnik);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void btnNoviUcesnik_Click(object sender, EventArgs e)
        {
            if (listKupac.SelectedIndices.Count == 1)
            {
                ISession sesija = DataLayer.GetSession();
                ITransaction transakcija = sesija.BeginTransaction();

                Kupac kupac = (Kupac)listKupac.SelectedItem;
                kupac = sesija.Load<Kupac>(kupac.Id);
                Ucesnik ucesnik = new Ucesnik();
                ucesnik.DatumPrvePorudzbine = kupac.DatumPrvePorudzbine;

                ucesnik.SakupljeniBodovi = 0;
                ucesnik.Porudzbine = kupac.Porudzbine;

                sesija.Save(ucesnik);
                ucesnik.LicniBroj = kupac.LicniBroj;
                foreach (Porudzbina porudzbina in ucesnik.Porudzbine)
                {
                    porudzbina.IdKupca = ucesnik;
                }
                int i;
                for (i = 0; i < (kupac.Porudzbine).Count; i++)
                {
                    kupac.Porudzbine.RemoveAt(i);
                }
                listKupac.Items.Clear();
                listUcesnik.Items.Clear();
                sesija.Delete(kupac);
                transakcija.Commit();
                sesija.Close();

                //MessageBox.Show("KRAJ");
                UcitajKupce();
                UcitajUcesnike();
            }
            else
            {
                MessageBox.Show("Izaberite jednog kupca");
            }
        }

        private void NoviUcesnik_Load(object sender, EventArgs e)
        {

        }
    }
}
