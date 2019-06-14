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
        public IsporucenaPorudzbina porudzbina;
        public Isporuci()
        {
            InitializeComponent();

            porudzbina = new IsporucenaPorudzbina();

            UcitajNeisporucene();

            UcitajDostavljace();
        }
        private void UcitajVozila()
        {
            if (listBox2.SelectedIndices.Count == 1)
            {
                ISession sesija = DataLayer.GetSession();
                Dostavljac dostavljac = sesija.Load<Dostavljac>( ( (Dostavljac)listBox2.SelectedItem).Id );
                listBox3.Items.Clear();
                foreach (Vozilo vozilo in dostavljac.Vozila)
                {
                    listBox3.Items.Add(vozilo);
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
                ISession s = DataLayer.GetSession();

                IList<Dostavljac> dostavljaci = s.QueryOver<Dostavljac>()
                                                .List<Dostavljac>();

                foreach (Dostavljac dostavljac in dostavljaci)
                {
                    listBox2.Items.Add(dostavljac);
                }

                s.Close();

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
                ISession s = DataLayer.GetSession();

                IList<NeisporucenaPorudzbina> porudzbine = s.QueryOver<NeisporucenaPorudzbina>()
                                                .List<NeisporucenaPorudzbina>();

                foreach (NeisporucenaPorudzbina np in porudzbine)
                {
                    listBox1.Items.Add(np);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1 && listBox2.SelectedIndices.Count == 1 && listBox3.SelectedIndices.Count == 1)
            {
                porudzbina.DatumVremeIsporuke = DateTime.Now;
                //ubacivanje porudzbine u bazu
            }
            else {
                MessageBox.Show("Izaberite po podatak iz svakog polja");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NeisporucenaPorudzbina np = (NeisporucenaPorudzbina)listBox1.SelectedItem;
            porudzbina.DatumVremeKreiranja = np.DatumVremeKreiranja;
            porudzbina.IdKupca = np.IdKupca;
            porudzbina.Sadrzaj = np.Sadrzaj;
            porudzbina.NacinPlacanja = np.NacinPlacanja;
            porudzbina.IdOperater = np.IdOperater;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count == 1)
            {
                porudzbina.IdDostavljac = (Dostavljac)listBox2.SelectedItem;
                UcitajVozila();
            }
            else
                MessageBox.Show("Izaberite jednu porudzbinu");
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndices.Count == 1)
            {
                porudzbina.IdVozilo = (Vozilo)listBox3.SelectedItem;
            }
            else
                MessageBox.Show("Izaberite jednog dostavljaca");
        }

        private void Isporuci_Load(object sender, EventArgs e)
        {

        }
    }
}
