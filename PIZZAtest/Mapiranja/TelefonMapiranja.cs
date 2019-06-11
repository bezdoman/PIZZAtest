using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using PIZZAtest.Entiteti;

namespace PIZZAtest.Mapiranja
{
    class TelefonMapiranja:ClassMap<Telefon>
    {
        public TelefonMapiranja()
        {
            Table("BROJ_TEL");

            CompositeId()
                        .KeyReference(x => x.OsobaKontakt, "OSOBA_ID")
                        .KeyProperty(x => x.TelefonKontakt, "BROJ_TELEFONA");
        }
    }
}
