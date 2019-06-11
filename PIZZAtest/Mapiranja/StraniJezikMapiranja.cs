using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class StraniJezikMapiranja:ClassMap<StraniJezik>
    {
        public StraniJezikMapiranja()
        {
            Table("STRANI_JEZIK");

            CompositeId()
                    .KeyReference(x => x.ZaposleniId, "ZAPOSLENI_ID")
                    .KeyProperty(x => x.Jezik, "JEZIK");

            Map(x => x.Nivo, "NIVO");
        }
    }
}
