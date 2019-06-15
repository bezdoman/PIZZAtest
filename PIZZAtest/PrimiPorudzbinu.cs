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
        private BindingList<Sadrzi> sadrzi;
        public PrimiPorudzbinu()
        {
            sadrzi=new BindingList<Sadrzi>();
            InitializeComponent();
            listSadrzaj.DataSource = sadrzi;

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
                    kupac.DatumPrvePorudzbine = DateTime.Now;
                    kupac.LicniBroj = osoba;
                    s.Save(kupac);
                    s.Close();

                    listKupac.Items.Clear();
                    UcitajKupce();
                }
            }
        }
        

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            Sadrzi s = new Sadrzi()
            {
                VelicinaId = (VelicinaPizze)comboVelicina.SelectedItem,
                PizzaId = (Pizza)comboPizza.SelectedItem
            };
            foreach (Sadrzi sadrzaj in listSadrzaj.Items)
            {
                if (s.VelicinaId == sadrzaj.VelicinaId && s.PizzaId == sadrzaj.PizzaId)
                    return;

            }
            sadrzi.Add(s);
        }

        private void btnPrimiPorudzibnu_Click(object sender, EventArgs e)
        {
            if (listOperater.SelectedItems.Count == 0 || listKupac.SelectedItems.Count == 0 || sadrzi.Count==0|| comboNacinPlacanja.SelectedItem==null)
            {
                MessageBox.Show("Morate izbrati jednog operatera,dostavaljaca,nacin placanja i popuniti sadrzaj bar jedne porudzbine");
                return;
            }
            ISession s = DataLayer.GetSession();
            ITransaction t = s.BeginTransaction();

            Kupac k = s.Load<Kupac>(((Kupac)listKupac.SelectedItem).Id);
            int suma = 0;
            
            Operater o = s.Load<Operater>(((Operater)listOperater.SelectedItem).Id);
            NeisporucenaPorudzbina p = new NeisporucenaPorudzbina()
            {
                NacinPlacanja = comboNacinPlacanja.Text,
                IdKupca = k,
                IdOperater = o,
                DatumVremeKreiranja = DateTime.Now
            };
            s.Save(p);
            k.Porudzbine.Add(p);
            o.PrimljenePorudzbine.Add(p);
            foreach (var x in sadrzi)
            {
                x.PorudzbinaId = p;
                s.Save(x);
                p.Sadrzaj.Add(x);
                suma += x.VelicinaId.Bodovi;
            }
          //  k = (Ucesnik)k;
            if (k.GetType() == typeof(Ucesnik))
            {
                ISession sesija = DataLayer.GetSession();
                ITransaction transakcija = sesija.BeginTransaction();

                sesija.Delete(k);
                transakcija.Commit();

                listOperater.Items.Clear();
                listKupac.Items.Clear();

                Ucesnik novi = new Ucesnik();
                novi.DatumPrvePorudzbine = novi.DatumPrvePorudzbine;

                novi.SakupljeniBodovi = ((Ucesnik)k).SakupljeniBodovi + suma;
                novi.Porudzbine = k.Porudzbine;
                novi.LicniBroj = k.LicniBroj;
                sesija.Save(novi);

                sesija.Close();

                sesija = DataLayer.GetSession();
                transakcija = sesija.BeginTransaction();
                foreach (Porudzbina porudzbina in k.Porudzbine)
                {
                    Porudzbina por;
                    if (porudzbina.GetType() == typeof(NeisporucenaPorudzbina))
                        por = new NeisporucenaPorudzbina();
                    else
                        por = new IsporucenaPorudzbina();
                    por = porudzbina;
                    por.IdKupca = novi;
                    sesija.Save(por);

                }
                foreach (Poklon nagrada in ((Ucesnik)k).Pokloni)
                {
                    Poklon pok;
                    if (nagrada.GetType() == typeof(PoklonPopust))
                        pok = new PoklonPopust();
                    else
                        pok = new PoklonPizza();
                    pok = nagrada;
                    pok.IdKupca = novi;
                    sesija.Save(pok);
                }
                transakcija.Commit();
                sesija.Close();
    //            k = novi;
            }
            t.Commit();
            s.Close();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
