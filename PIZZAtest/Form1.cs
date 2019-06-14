using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Linq;

using PIZZAtest.Entiteti;

namespace PIZZAtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UcitajNeisporucene() {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<NeisporucenaPorudzbina> porudzbine = s.QueryOver<NeisporucenaPorudzbina>()
                                                //.Where(x => x.Stanje == "Neisporucena")
                                                .List<NeisporucenaPorudzbina>();
                IList<NeisporucenaPorudzbina> porudzbine2 = porudzbine;

                foreach (NeisporucenaPorudzbina np in porudzbine2)
                {
                    MessageBox.Show(np.Idp.ToString());
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void Isporuci(NeisporucenaPorudzbina np) { }
       // private void DodajBodove() { }
        private void NoviUcesnik(Kupac kupac) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("start");
        }

        
        
        public void InsertUcesnik() {
            ISession s = DataLayer.GetSession();
            ITransaction t = s.BeginTransaction();
            Osoba o = s.Load<Osoba>(23);
            MessageBox.Show(o.Ime);
            Entiteti.Ucesnik u = new Entiteti.Ucesnik
            {
                DatumPrvePorudzbine = new DateTime(2018, 12, 12),
                SakupljeniBodovi = 500
            };
            u.LicniBroj = o;
            s.SaveOrUpdate(u);
            t.Commit();

            s.Close();
            MessageBox.Show("kraj");
        }
       
        private void InsertOsoba_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction t = s.BeginTransaction();
                Osoba o = new Osoba()
                {
                    Ime = "Ema",
                    Prezime = "Karic",
                    Ulica = "Knjazevacka",
                    Broj = 22,
                    Grad = "Nis",
                    Drzava = "Srbija"
                };


                s.Save(o);
                t.Commit();

                s.Close();
                MessageBox.Show("kraj");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void InsertKontakt_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction t = s.BeginTransaction();
                Osoba o = new Osoba()
                {
                    Ime = "Vladan",
                    Prezime = "Mirkovic",
                    Ulica = "Knjazevacka",
                    Broj = 11,
                    Grad = "Nis",
                    Drzava = "Srbija"
                };
                s.Save(o);
                Email email = new Email();
                email.EmailKontakt = "markommm@gmail.com";
                email.OsobaKontakt = o;
                s.Save(email);
                Telefon telefon = new Telefon();
                telefon.TelefonKontakt = "0652244244";
                telefon.OsobaKontakt = o;
                s.Save(telefon);
                o.Emailovi.Add(email);
                o.Telefoni.Add(telefon);

                s.Update(o);
                t.Commit();
                MessageBox.Show("KRAJ");
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void UcesnikPoklon_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Ucesnik korisnik = s.Load<Ucesnik>(8);
                MessageBox.Show(korisnik.Id + " " + korisnik.LicniBroj.Ime);
                string podaci = "";
                foreach(Poklon p in korisnik.Pokloni)
                {
                    podaci += p.DatumDodele.ToShortDateString() + " " + p.Tip+"\n";
                }
                MessageBox.Show(podaci);
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Osoba osobica = sesija.Load<Osoba>(17);
                
                MessageBox.Show(osobica.Ime + " " + osobica.Prezime);
                string podaci = "";
                foreach (Telefon podatak in osobica.Telefoni)
                {
                    podaci += podatak.TelefonKontakt + "\n";
                }
                foreach (Email podatak in osobica.Emailovi)
                {
                    podaci += podatak.EmailKontakt + "\n";
                }
                MessageBox.Show(podaci);
                sesija.Close();
            }
            catch(Exception exc) { MessageBox.Show(exc.Message); }

        }

        private void Smene_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Zaposleni radnik = sesija.Load<Zaposleni>(3);

                MessageBox.Show(radnik.LicniBroj.Ime + " " + radnik.JMBG + " " +radnik.Tip);
                string podaci = "";
                foreach (RadiUSmeni podatak in radnik.RadneNedelje)
                {
                    podaci += podatak.DatumOd + " " + podatak.Smena + ". smena\n";
                }
                MessageBox.Show(podaci);

                sesija.Close();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void Jezici_Click(object sender, EventArgs e)
        {
            ISession sesija = DataLayer.GetSession();

            Operater radnik = sesija.Load<Operater>(5);

            MessageBox.Show(radnik.LicniBroj.Ime + " " + radnik.JMBG + " " + radnik.Tip);
            string podaci = "";
            foreach (StraniJezik podatak in radnik.Jezici)
            {
                podaci += podatak.Jezik + " " + podatak.Nivo + "\n";
            }
            MessageBox.Show(podaci);

            sesija.Close();
        }

        private void Vozila_Click(object sender, EventArgs e)
        {
            try
            { 
            ISession sesija = DataLayer.GetSession();

            Dostavljac radnik = sesija.Load<Dostavljac>(3);

            MessageBox.Show(radnik.LicniBroj.Ime + " " + radnik.JMBG + " " + radnik.Tip);
            string podaci = "";
            foreach (Vozilo podatak in radnik.Vozila)
            {
                podaci += podatak.Tip + " " + podatak.Proizvodjac + " " + podatak.Model + "\n";
            }
            foreach (Porudzbina podatak in radnik.DostavljenePorudzbine)
            {
                podaci += podatak.Stanje + " " +podatak.DatumVremeKreiranja + "\n";
            }
            MessageBox.Show(podaci);

            sesija.Close();
             }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void Dodaci_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Pizza p = sesija.Load<Pizza>("Kalcona");

                MessageBox.Show(p.Naziv + " " + p.Cena);
                string podaci = "";
                foreach (Dodaci podatak in p.Sastojci)
                {
                    podaci += podatak.Dodatak + "\n";
                }
                
                MessageBox.Show(podaci);

                sesija.Close();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void Ukupno_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                Porudzbina p = sesija.Load<Porudzbina>(13);

                MessageBox.Show("Narudzbina broj: "+p.Idp+"\n");
                string podaci = "";
                int ukupno = 0;
                int cena = 0;
                foreach (Sadrzi podatak in p.Sadrzaj)
                {
                    Pizza pizza = podatak.PizzaId;
                    VelicinaPizze velicina = podatak.VelicinaId;
                    podaci += pizza.Naziv +" cena: " +pizza.Cena+" velicina: "+velicina.Velicina+" bodovi: "+ velicina.Bodovi+"\n";
                    ukupno += velicina.Bodovi;
                    cena += pizza.Cena;
                }
                MessageBox.Show(podaci+"\nUkupna cena: "+cena+"\nUkupno bodova: " + ukupno);

                sesija.Close();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void InsertPorudzbina_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                ITransaction tran = sesija.BeginTransaction();
                Operater o = sesija.Load<Operater>(2);
                Kupac k = sesija.Load<Kupac>(19);
                DateTime datum = new DateTime(2019, 5, 5);
                NeisporucenaPorudzbina p = new NeisporucenaPorudzbina();
                p.DatumVremeKreiranja = datum;
                    
                p.NacinPlacanja = "KARTICA";
                sesija.Save(p);
                p.IdOperater = o;
                p.IdKupca = k;//,
                
                Sadrzi s = new Sadrzi()
                {
                    PizzaId = sesija.Load<Pizza>("Kalcona"),
                    VelicinaId = sesija.Load<VelicinaPizze>("Srednja"),
                    PorudzbinaId = p
                };
                
                sesija.Save(s);

                o.PrimljenePorudzbine.Add(p);
                k.Porudzbine.Add(p);

                sesija.Update(k);
                sesija.Update(o);

                sesija.Update(s);

                tran.Commit();
                sesija.Close();
                MessageBox.Show("KRAJ");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void NoviZaposleni_Click(object sender, EventArgs e)
        {
            
            try
            {
                ISession sesija = DataLayer.GetSession();
                ITransaction tran = sesija.BeginTransaction();
                //1 operater
                Osoba o = new Osoba()
                {
                    Ime = "Ema",
                    Prezime = "Karic",
                    Ulica = "Knjazevacka",
                    Broj = 22,
                    Grad = "Nis",
                    Drzava = "Srbija"
                };
                sesija.Save(o);

                Operater operater = new Operater();
                operater.DatumRodjenja = new DateTime(1990, 12, 12);
                operater.JMBG = 121299012;
                
                sesija.Save(operater);

                operater.LicniBroj = o;
                sesija.Update(operater);

                //2 Dostavljac
                Osoba o2 = new Osoba()
                {
                    Ime = "Mirko",
                    Prezime = "Miric",
                    Ulica = "Vozda Karadjordja",
                    Broj = 13,
                    Grad = "Nis",
                    Drzava = "Srbija"
                };
                sesija.Save(o2);

                Dostavljac dostavljac = new Dostavljac();
                dostavljac.DatumRodjenja = new DateTime(1990, 12, 12);
                dostavljac.JMBG = 121299012;
               // dostavljac.Kategorija = "B";

                sesija.Save(dostavljac);

                operater.LicniBroj = o2;
                sesija.Update(dostavljac);



                tran.Commit();
                sesija.Close();
                MessageBox.Show("KRAJ");
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction t = s.BeginTransaction();
                Osoba o = s.Load<Osoba>(23);
                Osoba o2 = s.Load<Osoba>(105);
                MessageBox.Show(o.Ime);
                Entiteti.Ucesnik u = new Entiteti.Ucesnik
                {
                    DatumPrvePorudzbine = new DateTime(2018, 12, 12),
                    SakupljeniBodovi = 500
                };
                s.Save(u);
                u.LicniBroj = o;
                s.Update(u);
                MessageBox.Show(o2.Ime);
                Entiteti.Kupac k = new Entiteti.Kupac
                {
                    DatumPrvePorudzbine = new DateTime(2018, 12, 12)
                };
                s.Save(k);
                k.LicniBroj = o2;
                s.Update(k);
                t.Commit();

                s.Close();
                MessageBox.Show("kraj");
            }

            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction t = s.BeginTransaction();
                Dostavljac z = s.Load<Dostavljac>(8);

                Skuter v = new Skuter();
                v.Model = "SR 50 R";
                v.Proizvodjac = "APRILIA";
                //v.Dozvola = 1552127;
                //v.Registracija = "338-PZ";
                v.IdZaposleni = z;
                s.Save(v);


                //v.IdZaposleni = z;
       //      v.IdZaposleni.Vozila.Add(v);
                //s.Update(v);
                //s.Update(z);
                t.Commit();
                s.Close();
                MessageBox.Show("kraj");
            }

            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ITransaction t = s.BeginTransaction();
                Dostavljac d = s.Load<Dostavljac>(8);
                Operater o = s.Load<Operater>(1);
                RadiUSmeni rus = new RadiUSmeni();
                rus.DatumOd = new DateTime(2019, 5, 6);
                rus.Smena = 2;
                rus.ZaposleniId = d;
                s.Save(rus);
                d.RadneNedelje.Add(rus);
                RadiUSmeni rus2 = new RadiUSmeni();
                rus.DatumOd = new DateTime(2019, 5, 6);
                rus.Smena = 2;
                rus.ZaposleniId = o;
                s.Save(rus);
                o.RadneNedelje.Add(rus);
                t.Commit();
                MessageBox.Show("KRAJ");
                s.Close();
            }

            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UcitajNeisporucene();
        }

        private void button6_Click(object sender, EventArgs e)
        {    
        }

        private void btnPrimiPorudzbinu_Click(object sender, EventArgs e)
        {
            using (PrimiPorudzbinu forma = new PrimiPorudzbinu())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    //Osoba osoba = s.Load<Osoba>(forma.broj);
                    //MessageBox.Show($"Ime:{osoba.Ime} i prezime:{osoba.Prezime}");
                    s.Close();
                }
            }
        }

        private void btnIsporuci_Click(object sender, EventArgs e)
        {
            using (Isporuci forma = new Isporuci())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    //Osoba osoba = s.Load<Osoba>(forma.broj);
                    //MessageBox.Show($"Ime:{osoba.Ime} i prezime:{osoba.Prezime}");
                    s.Close();
                }
            }
        }

        private void btnUcesnik_Click(object sender, EventArgs e)
        {
            using (NoviUcesnik forma = new NoviUcesnik())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    //Osoba osoba = s.Load<Osoba>(forma.broj);
                    //MessageBox.Show($"Ime:{osoba.Ime} i prezime:{osoba.Prezime}");
                    s.Close();
                }
            }
        }

        private void btnNoviZaposleni_Click(object sender, EventArgs e)
        {
            using (NoviZaposleni forma = new NoviZaposleni())
            {
                if (forma.ShowDialog() == DialogResult.OK)
                {
                    ISession s = DataLayer.GetSession();
                    //Osoba osoba = s.Load<Osoba>(forma.broj);
                    //MessageBox.Show($"Ime:{osoba.Ime} i prezime:{osoba.Prezime}");
                    s.Close();
                }
            }
        }
    }
}
