using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class RadiUSmeniMapiranja:ClassMap<RadiUSmeni>
    {
        public RadiUSmeniMapiranja()
        {
            Table("RADI_U_SMENI");

            CompositeId()
                    .KeyReference(x => x.ZaposleniId, "ZAPOSLENI_ID")
                    .KeyProperty(x => x.DatumOd, "DATUM_OD");

            Map(x => x.Smena, "SMENA");

        }
    }
}
