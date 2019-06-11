using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIZZAtest.Entiteti
{
    public class StraniJezik
    {
        public virtual Operater ZaposleniId { get; set; }
        public virtual string Jezik { get; set; }
        public virtual string Nivo { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(StraniJezik))
                return false;

            StraniJezik recievedObject = (StraniJezik)obj;

            if ((ZaposleniId.Id == recievedObject.ZaposleniId.Id) &&
                (Jezik.Equals(recievedObject.Jezik)))
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
