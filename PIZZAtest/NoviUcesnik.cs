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
        private void UcitajKupce() {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Kupac> kupci = s.QueryOver<Kupac>()
                                                .Where(x=>x.Flag=="NE")
                                                .List<Kupac>();



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
        private void UcitajUcesnike() {
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
                Kupac kupac = (Kupac)listKupac.SelectedItem;
                //...
            }
            else
                MessageBox.Show("Izaberite jednog kupca");
        }

        private void NoviUcesnik_Load(object sender, EventArgs e)
        {

        }

        private void listKupac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
