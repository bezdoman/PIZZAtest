using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class PoklonMapiranja : ClassMap<Poklon>
    {
        public PoklonMapiranja()
        {
            Table("POKLON");

            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.Id, "BROJ").GeneratedBy.TriggerIdentity();
            
            //mapiranje svojstava
            Map(x => x.Bodovi, "BODOVI");
            Map(x => x.DatumDodele, "DATUM_DODELJIVANJA");
            Map(x => x.DatumIskoriscen, "DATUM_ISKORISCEN");
          //  Map(x => x.Tip, "TIP");

            References(x => x.IdKupca).Column("ID_KUPAC").LazyLoad();
        }
    }
    public class PoklonPizzaMapiranja : SubclassMap<PoklonPizza>
    {
        public PoklonPizzaMapiranja()
        {
            DiscriminatorValue("PIZZA");
        }
    }
    public class PoklonPopustMapiranja : SubclassMap<PoklonPopust>
    {
        public PoklonPopustMapiranja()
        {
            DiscriminatorValue("POPUST");
        }
    }
}
