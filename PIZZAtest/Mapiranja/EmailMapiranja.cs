using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using PIZZAtest.Entiteti;

namespace PIZZAtest.Mapiranja
{
    class EmailMapiranja:ClassMap<Email>
    {
        public EmailMapiranja()
        {
            Table("EMAIL");

            CompositeId()
                    .KeyReference(x => x.OsobaKontakt, "OSOBA_ID")
                    .KeyProperty(x => x.EmailKontakt, "EMAIL_ADRESA");
        }
    }
}
