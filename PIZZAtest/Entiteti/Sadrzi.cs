using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public class Sadrzi
    {
        public virtual Porudzbina PorudzbinaId { get; set; }
        public virtual Pizza PizzaId { get; set; }
        public virtual VelicinaPizze VelicinaId { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(Sadrzi))
                return false;

            Sadrzi recievedObject = (Sadrzi)obj;

            if ((PorudzbinaId.Idp == recievedObject.PorudzbinaId.Idp) &&
                (PizzaId.Naziv == recievedObject.PizzaId.Naziv) &&
                (VelicinaId.Velicina == recievedObject.VelicinaId.Velicina))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
