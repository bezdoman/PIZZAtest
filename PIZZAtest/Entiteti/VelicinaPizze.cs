using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public class VelicinaPizze
    {
        public virtual string Velicina { get; set; }
        public virtual int Bodovi { get; set; }
        public virtual IList<Sadrzi> Pizze { get; set; }
        public VelicinaPizze()
        {
            Pizze = new List<Sadrzi>();
        }

        public override string ToString()
        {
            return Velicina;
        }
    }
}
