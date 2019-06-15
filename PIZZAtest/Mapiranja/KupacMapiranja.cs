using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PIZZAtest.Entiteti;

namespace PIZZAtest.Mapiranja
{
    class KupacMapiranja:ClassMap<Kupac>
    {
        public KupacMapiranja()
        {
            Table("KUPAC");

            DiscriminateSubClassesOnColumn("UCESNIK_FLAG", "NE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.DatumPrvePorudzbine, "DATUM_PRVE_PORUDZBINE");
          //  Map(x => x.Flag, "UCESNIK_FLAG");

            References(x => x.LicniBroj).Column("LICNI_BROJ").LazyLoad();

            HasMany(x => x.Porudzbine).KeyColumn("ID_KUPCA").Inverse().Cascade.AllDeleteOrphan();
        }
    }
    class UcesnikMapiranja : SubclassMap<Ucesnik>
    {
        public UcesnikMapiranja()
        {
            DiscriminatorValue("DA");
            Map(x => x.SakupljeniBodovi, "SAKUPLJENI_BODOVI");
            //Ucesnik-Poklon 1:N
            HasMany(x => x.Pokloni).KeyColumn("ID_KUPAC").Inverse().Cascade.All();

        }
    }
}
