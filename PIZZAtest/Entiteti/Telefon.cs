using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIZZAtest.Entiteti
{
    public class Telefon
    {
        public virtual Osoba OsobaKontakt { get; set; }
        public virtual string TelefonKontakt { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(Telefon))
                return false;

            Telefon recievedObject = (Telefon)obj;

            if ((OsobaKontakt.Id == recievedObject.OsobaKontakt.Id) &&
                (TelefonKontakt.Equals(recievedObject.TelefonKontakt)))
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
