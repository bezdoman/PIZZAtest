using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIZZAtest.Entiteti
{
    public class Pizza
    {
        public virtual string Naziv { get; set; }
        public virtual int Cena { get; set; }
        public virtual IList<Sadrzi> Narucene { get; set; }
        public virtual IList<Dodaci> Sastojci { get; set; }
        public Pizza()
        {
            Narucene = new List<Sadrzi>();
            Sastojci = new List<Dodaci>();
        }

    }
}
