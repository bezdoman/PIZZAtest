using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public abstract class Poklon
    {
        public virtual int Id { get; set; }
        public virtual string Tip { get; set; }
        public virtual int Bodovi { get; set; }
        public virtual DateTime DatumDodele { get; set; }
        public virtual DateTime DatumIskoriscen { get; set; }
        public virtual Ucesnik IdKupca { get; set; }
    }
    public class PoklonPopust : Poklon {


    }
    public class PoklonPizza : Poklon {


    }
}


