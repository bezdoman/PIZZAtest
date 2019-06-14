using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public abstract class Porudzbina
    {
        public virtual int Idp { get; set; }
        public virtual string Stanje { get; set; }
        public virtual DateTime DatumVremeKreiranja { get; set; }
        public virtual Operater IdOperater { get; set; }
        public virtual Kupac IdKupca { get; set; }
        public virtual string NacinPlacanja { get; set; }
        public virtual IList<Sadrzi> Sadrzaj { get; set; }

        public override string ToString()
        {
            return Idp.ToString()+" "+DatumVremeKreiranja.ToShortDateString() + " " + IdKupca.Id.ToString() + " " + Stanje;
        }
        public Porudzbina()
        {
            Sadrzaj = new List<Sadrzi>();
        }
    }
    public class IsporucenaPorudzbina:Porudzbina
    {
        public virtual Dostavljac IdDostavljac { get; set; }
        public virtual Vozilo IdVozilo { get; set; }
        public virtual DateTime DatumVremeIsporuke { get; set; }
    }
    public class NeisporucenaPorudzbina : Porudzbina { }
}
