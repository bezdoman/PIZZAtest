using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Entiteti
{
    public abstract class Zaposleni
    {
        public virtual int Id { get;  set; }
        public virtual int JMBG { get;  set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Tip { get; set; }
        public virtual Osoba LicniBroj { get; set; }
        public virtual IList<RadiUSmeni> RadneNedelje { get; set; }
        
        public Zaposleni()
        {
            RadneNedelje = new List<RadiUSmeni>();
        }

    }
    public class Dostavljac : Zaposleni
    {
        public virtual string Kategorija { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }
        public virtual IList<IsporucenaPorudzbina> DostavljenePorudzbine { get; set; }
        
        public Dostavljac()
        {
           // Tip = "Dostavljac";
            Vozila = new List<Vozilo>();
            DostavljenePorudzbine = new List<IsporucenaPorudzbina>();
        }

        public override string ToString()
        {
            return Id + " " + LicniBroj.ToString();
        }
    }
    public class Operater : Zaposleni
    {
        public virtual IList<StraniJezik> Jezici { get; set; }
        public virtual IList<Porudzbina> PrimljenePorudzbine { get; set; }
    
        public Operater()
        {
            //Tip = "Operater";
            Jezici = new List<StraniJezik>();
            PrimljenePorudzbine = new List<Porudzbina>();
        }

        public override string ToString()
        {
            return Id + " " + JMBG + " " + LicniBroj.ToString();
        }
    }
}
