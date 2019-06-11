using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class SadrziMapiranja:ClassMap<Sadrzi>
    {
        public SadrziMapiranja()
        {
            Table("SADRZI");

            CompositeId()
                .KeyReference(x => x.PorudzbinaId, "ID_PORUDZBINE")
                .KeyReference(x => x.PizzaId, "NAZIV_PIZZE")
                .KeyReference(x => x.VelicinaId, "VELICINA");
        }
    }
}
