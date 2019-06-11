using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using PIZZAtest.Entiteti;

namespace PIZZAtest.Mapiranja
{
    class OsobaMapiranja:ClassMap<PIZZAtest.Entiteti.Osoba>
    {
        public OsobaMapiranja()
        {
            //Mapiranje tabele
            Table("OSOBA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Ulica, "ULICA");
            Map(x => x.Broj, "BROJ");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Drzava, "DRZAVA");

                                //Osoba-Email 1:N
            HasMany(x => x.Emailovi).KeyColumn("OSOBA_ID").LazyLoad().Cascade.All().Inverse();
                                //Osoba-Telefon 1:N
            HasMany(x => x.Telefoni).KeyColumn("OSOBA_ID").LazyLoad().Cascade.All().Inverse();
            
        }
    }
}
