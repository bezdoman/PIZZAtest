using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIZZAtest.Entiteti
{
    public class Osoba
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual string Grad { get; set; }
        public virtual string Drzava { get; set; }

        public virtual IList<Telefon> Telefoni { get; set; }
        public virtual IList<Email> Emailovi { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(Osoba))
                return false;

            Osoba recievedObject = (Osoba)obj;

            if (Id == recievedObject.Id)
            {
                return true;
            }

            return false;
        }
            

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        public Osoba()
        { 
            Telefoni = new List<Telefon>();
            Emailovi = new List<Email>();
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
