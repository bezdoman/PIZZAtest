using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public class Dodaci
    {
        public virtual Pizza Naziv { get; set; }
        public virtual string Dodatak { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(Dodaci))
                return false;

            Dodaci recievedObject = (Dodaci)obj;

            if ((Naziv.Naziv == recievedObject.Naziv.Naziv) &&
                (Dodatak.Equals(recievedObject.Dodatak)))
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
