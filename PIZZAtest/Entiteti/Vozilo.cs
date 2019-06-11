using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public abstract class Vozilo
    {
        public virtual int Idv { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Model { get; set; }
        public virtual string Proizvodjac { get; set; }
        
        
        public virtual Dostavljac IdZaposleni { get; set; }
        public virtual IList<IsporucenaPorudzbina> Porudzbine { get; set; }
        public Vozilo()
        {
            Porudzbine=new List<IsporucenaPorudzbina>();
        }
    }
    public class Bicikl : Vozilo
    {
        public virtual int Ram { get; set; }
    }
    public class Skuter : Vozilo
    {
        public virtual int Dozvola { get; set; }
        public virtual string Registracija { get; set; }
    }
    public class Automobil : Vozilo
    {
        public virtual int Dozvola { get; set; }
        public virtual string Registracija { get; set; }
    }
}
