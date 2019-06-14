using NHibernate;
using PIZZAtest.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void ucitajZaposlene(string kategorija) {
            ISession session = DataLayer.GetSession();
            IList<Dostavljac> dostavljacs = session.QueryOver<Dostavljac>()
                                .Where(x => x.Kategorija == kategorija)
                                .List<Dostavljac>();
        }

        private void radioButtonBicikl_CheckedChanged(object sender, EventArgs e)
        {
            try { 
                
                listBoxZaposleni.Items.Clear();
                groupBoxBickl.Visible = true;
            }
        }
    }
}
