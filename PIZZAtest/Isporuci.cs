using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIZZAtest.Entiteti;
using NHibernate;

namespace PIZZAtest
{
    public partial class Isporuci : Form
    {
       // public IsporucenaPorudzbina porudzbina;
        IList<Dostavljac> dostavljaci;
        IList<NeisporucenaPorudzbina> porudzbine;
        public Isporuci()
        {
            InitializeComponent();

           // porudzbina = new IsporucenaPorudzbina();

            UcitajNeisporucene();

            UcitajDostavljace();
        }
        private void UcitajVozila()
        {
            if (listDostavljac.SelectedIndices.Count == 1)
            {
                ISession sesija = DataLayer.GetSession();
                Dostavljac dostavljac = sesija.Load<Dostavljac>( ( (Dostavljac)listDostavljac.SelectedItem).Id );
                listVozilo.Items.Clear();
                foreach (Vozilo vozilo in dostavljac.Vozila)
                {
                    listVozilo.Items.Add(vozilo);
                }
                sesija.Close();
            }
            else
                MessageBox.Show("Izaberite jednog dostavljaca");
        }
        private void UcitajDostavljace()
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                dostavljaci = sesija.QueryOver<Dostavljac>()
                                                //.Where(x=>x.Kategorija=="B")
                                                .List<Dostavljac>();

                

                foreach (Dostavljac dostavljac in dostavljaci)
                {
                   dostavljac.LicniBroj = sesija.QueryOver<Osoba>().Where(x => x.Id == dostavljac.LicniBroj.Id).List<Osoba>()[0];

                    listDostavljac.Items.Add(dostavljac);
                }

                sesija.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void UcitajNeisporucene()
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                porudzbine = sesija.QueryOver<NeisporucenaPorudzbina>()
                                                .List<NeisporucenaPorudzbina>();

                foreach (NeisporucenaPorudzbina np in porudzbine)
                {
                    np.IdKupca = sesija.QueryOver<Kupac>().Where(x => x.Id == np.IdKupca.Id).List<Kupac>()[0];

                    np.IdKupca.LicniBroj = sesija.QueryOver<Osoba>().Where(x => x.Id == np.IdKupca.LicniBroj.Id).List<Osoba>()[0];

                    listPorudzbina.Items.Add(np);
                }

                sesija.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listPorudzbina.SelectedIndices.Count == 1 && listDostavljac.SelectedIndices.Count == 1 && listVozilo.SelectedIndices.Count == 1)
            {
                ISession sesija = DataLayer.GetSession();
                ITransaction transakcija = sesija.BeginTransaction();

                NeisporucenaPorudzbina np = sesija.Load<NeisporucenaPorudzbina>(((NeisporucenaPorudzbina)listPorudzbina.SelectedItem).Idp);
                sesija.Delete(np);
                transakcija.Commit();

                Dostavljac dostavljac = sesija.Load<Dostavljac>(((Dostavljac)listDostavljac.SelectedItem).Id);
                Vozilo vozilo= sesija.Load<Vozilo>(((Vozilo)listVozilo.SelectedItem).Idv);
                IsporucenaPorudzbina porudzbina = new IsporucenaPorudzbina()
                {
                    DatumVremeIsporuke = DateTime.Now,
                    IdDostavljac = dostavljac,
                    IdVozilo = vozilo,
                    IdKupca=np.IdKupca,
                    IdOperater=np.IdOperater,
                    DatumVremeKreiranja=np.DatumVremeKreiranja,
                    NacinPlacanja=np.NacinPlacanja,
                    Sadrzaj=np.Sadrzaj
                };
                sesija.Save(porudzbina);

                porudzbina.IdKupca.Porudzbine.Remove(np);
                porudzbina.IdOperater.PrimljenePorudzbine.Remove(np);
               
                listPorudzbina.Items.Clear();
                listDostavljac.Items.Clear();
                listVozilo.Items.Clear();
                
                sesija.Close();


                sesija = DataLayer.GetSession();
                transakcija = sesija.BeginTransaction();
                foreach (Sadrzi sadrzaj in np.Sadrzaj)
                {
                    Sadrzi s=new Sadrzi();
                    s = sadrzaj;
                    s.PorudzbinaId = porudzbina;
                    sesija.Save(s);
                }
                transakcija.Commit();
                sesija.Close();

                UcitajNeisporucene();
                UcitajDostavljace();
                
            }
            else {
                MessageBox.Show("Izaberite po podatak iz svakog polja");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                UcitajVozila();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Isporuci_Load(object sender, EventArgs e)
        {

        }
    }
}
