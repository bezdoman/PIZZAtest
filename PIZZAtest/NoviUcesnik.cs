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
                ISession sesija = DataLayer.GetSession();

                IQuery sqlQuery = sesija.CreateSQLQuery("SELECT * FROM KUPAC WHERE UCESNIK_FLAG = 'NE'").AddEntity(typeof(Kupac));
                var kupci = sqlQuery.List<Kupac>();

                //IList<Kupac> kupci = s.QueryOver<Kupac>()
                //                                //.Where(x => x.Flag == "NE")
                //                                .List<Kupac>();



                foreach (Kupac kupac in kupci)
                {
                    kupac.LicniBroj = sesija.QueryOver<Osoba>().Where(x => x.Id == kupac.LicniBroj.Id).List<Osoba>()[0];

                    listKupac.Items.Add(kupac);
                }

                sesija.Close();

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
                ISession sesija = DataLayer.GetSession();

                IList<Ucesnik> ucesnici = sesija.QueryOver<Ucesnik>()
                                                //.Where(x=>x.Kategorija=="B")
                                                .List<Ucesnik>();



                foreach (Ucesnik ucesnik in ucesnici)
                {
                    ucesnik.LicniBroj = sesija.QueryOver<Osoba>().Where(x => x.Id == ucesnik.LicniBroj.Id).List<Osoba>()[0];

                    listUcesnik.Items.Add(ucesnik);
                }

                sesija.Close();

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
                sesija.Delete(kupac);
                transakcija.Commit();
                
                listKupac.Items.Clear();
                listUcesnik.Items.Clear();
                

                Ucesnik ucesnik = new Ucesnik();
                ucesnik.DatumPrvePorudzbine = kupac.DatumPrvePorudzbine;

                ucesnik.SakupljeniBodovi = 0;
                ucesnik.Porudzbine = kupac.Porudzbine;
                ucesnik.LicniBroj = kupac.LicniBroj;
                sesija.Save(ucesnik);

                sesija.Close();

                sesija = DataLayer.GetSession();
                transakcija = sesija.BeginTransaction();
                foreach (Porudzbina porudzbina in kupac.Porudzbine)
                {
                    Porudzbina p;
                    if (porudzbina.GetType() == typeof(NeisporucenaPorudzbina))
                        p = new NeisporucenaPorudzbina();
                    else
                        p = new IsporucenaPorudzbina();
                    p = porudzbina;
                    p.IdKupca = ucesnik;
                    sesija.Save(p);
                }
                transakcija.Commit();
                sesija.Close();
                
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
