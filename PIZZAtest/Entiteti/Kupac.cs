using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public class Kupac
    {
        public virtual int Id { get; set; }
        public virtual DateTime DatumPrvePorudzbine { get; set; }
        public virtual string Flag { get; set; }
        public virtual int SakupljeniBodovi { get; set; }
        public virtual Osoba LicniBroj { get; set; }
        public virtual IList<Porudzbina> Porudzbine { get; set; }
        public Kupac()
        {
            Porudzbine = new List<Porudzbina>();
        }

    }
    public class Ucesnik : Kupac
    {
        public virtual IList<Poklon> Pokloni { get; set; }
        public Ucesnik()
        {
            Pokloni = new List<Poklon>();
        }
        //public override bool Equals(object obj)
        //{
        //    if (Object.ReferenceEquals(this, obj))
        //        return true;

        //    if (obj.GetType() != typeof(Ucesnik))
        //        return false;

        //    Ucesnik recievedObject = (Ucesnik)obj;

        //    if ((Id == recievedObject.Id))
        //    {
        //        return true;
        //    }

        //    return false;
        //}
        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}
