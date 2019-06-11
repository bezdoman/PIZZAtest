using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class DodaciMapiranja:ClassMap<Dodaci>
    {
        public DodaciMapiranja()
        {
            Table("DODACI");

            CompositeId()
                     .KeyReference(x => x.Naziv, "NAZIV_PIZZE")
                     .KeyProperty(x => x.Dodatak, "DODACI_PIZZE");
        }
    }
}
