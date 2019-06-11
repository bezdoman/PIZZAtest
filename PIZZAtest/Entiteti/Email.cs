using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIZZAtest.Entiteti
{
    public class Email
    {
        public virtual Osoba OsobaKontakt { get; set; }
        public virtual string EmailKontakt { get; set; }
        
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(Email))
                return false;

            Email recievedObject = (Email)obj;

            if ((OsobaKontakt.Id == recievedObject.OsobaKontakt.Id) &&
                (EmailKontakt.Equals(recievedObject.EmailKontakt)))
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
