using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public class RadiUSmeni 
    {
        public virtual Zaposleni ZaposleniId { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual int Smena { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(RadiUSmeni))
                return false;

            RadiUSmeni recievedObject = (RadiUSmeni)obj;

            if ((ZaposleniId.Id == recievedObject.ZaposleniId.Id) &&
                (DatumOd.Equals(recievedObject.DatumOd)))
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
