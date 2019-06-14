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
using PIZZAtest.Mapiranja;

namespace PIZZAtest
{
    public partial class NovaPizza : Form
    {
        private BindingList<string> dodaci;
        public NovaPizza()
        {
            InitializeComponent();
            dodaci=new BindingList<string>();
            listBoxDodaci.DataSource = dodaci;
        }

        private void btnDodatak_Click(object sender, EventArgs e)
        {
            dodaci.Add(txtDodatak.Text);
        }

        private void btnDodajPizzu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction t = s.BeginTransaction();
                Pizza pizza = new Pizza()
                {
                    Naziv = txtPizza.Text,
                    Cena = int.Parse(txtCena.Text)
                };
                s.Save(pizza);
                foreach (var d in dodaci)
                {
                    Dodaci dodaci = new Dodaci()
                    {
                        Naziv = pizza,
                        Dodatak = d
                    };
                    s.Save(dodaci);
                    pizza.Sastojci.Add(dodaci);
                }
                t.Commit();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
