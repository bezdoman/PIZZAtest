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
    public partial class NoviPoklon : Form
    {
        public NoviPoklon()
        {
            InitializeComponent();

            UcitajUcesnike();
        }
        private void UcitajUcesnike() {
            ISession sesija = DataLayer.GetSession();
            IList<Ucesnik> ucesnici = sesija.QueryOver<Ucesnik>()
                //.Where(x => x.SakupljeniBodovi > 0)
                .List<Ucesnik>();

            foreach (Ucesnik ucesnik in ucesnici)
            {
                ucesnik.LicniBroj = sesija.QueryOver<Osoba>().Where(x => x.Id ==ucesnik.LicniBroj.Id).List<Osoba>()[0];

                listBox1.Items.Add(ucesnik);
            }
            sesija.Close();
        }
        private void NoviPoklon_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDodeli_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1)
            {
                ISession sesija = DataLayer.GetSession();
                ITransaction transakcija = sesija.BeginTransaction();
                
   //             sesija.Save(poklon);

                Ucesnik ucesnik = (Ucesnik)listBox1.SelectedItem;
                ucesnik = sesija.Load<Ucesnik>(ucesnik.Id);
                sesija.Delete(ucesnik);
                transakcija.Commit();

                listBox1.Items.Clear();

                Ucesnik dobitnik = new Ucesnik();
                dobitnik.DatumPrvePorudzbine = ucesnik.DatumPrvePorudzbine;

                Poklon poklon;
                if (radioPizza.Checked)
                    poklon = new PoklonPizza();
                else
                    poklon = new PoklonPopust();
                poklon.Bodovi = (int)numericUpDown1.Value;

                dobitnik.SakupljeniBodovi = ucesnik.SakupljeniBodovi-poklon.Bodovi;
                dobitnik.Porudzbine = ucesnik.Porudzbine;
                dobitnik.LicniBroj = ucesnik.LicniBroj;
                sesija.Save(dobitnik);

                sesija.Close();

                sesija = DataLayer.GetSession();
                transakcija = sesija.BeginTransaction();
                poklon.DatumDodele = DateTime.Now;
                poklon.DatumIskoriscen = DateTime.Now;
                poklon.IdKupca = dobitnik;
                sesija.Save(poklon);
                transakcija.Commit();
                sesija.Close();

                sesija = DataLayer.GetSession();
                transakcija = sesija.BeginTransaction();
                foreach (Porudzbina porudzbina in ucesnik.Porudzbine)
                {
                    Porudzbina p;
                    if (porudzbina.GetType() == typeof(NeisporucenaPorudzbina))
                        p = new NeisporucenaPorudzbina();
                    else
                        p = new IsporucenaPorudzbina();
                    p = porudzbina;
                    p.IdKupca = dobitnik;
                    sesija.Save(p);
                }
                foreach (Poklon nagrada in ucesnik.Pokloni)
                {
                    Poklon p;
                    if (nagrada.GetType() == typeof(PoklonPopust))
                        p = new PoklonPopust();
                    else
                        p = new PoklonPizza();
                    p = nagrada;
                    p.IdKupca = dobitnik;
                    sesija.Save(p);
                }
                transakcija.Commit();
                sesija.Close();

                UcitajUcesnike();
            }
            else
            {
                MessageBox.Show("Izaberite jednog ucesnika");
            }
        }

        
    }
}
