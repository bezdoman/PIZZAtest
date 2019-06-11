using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class VoziloMapiranja:ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            Table("VOZILO");

            DiscriminateSubClassesOnColumn("TIP_VOZILA");
            //mapiranje primarnog kljuca
            Id(x => x.Idv, "IDV").GeneratedBy.SequenceIdentity("S16107.VOZILO_ID_SEQ");

            //mapiranje svojstava
            //Map(x => x.Tip, "TIP_VOZILA");
            Map(x => x.Model, "NAZIV_MODELA");
            Map(x => x.Proizvodjac, "PROIZVODJAC");

            //Osoba-Email 1:N
            References(x => x.IdZaposleni).Column("ID_ZAPOSLENI");

            HasMany(x => x.Porudzbine).KeyColumn("ID_VOZILO").Inverse().Cascade.All();
        }
    }
    class BiciklMapiranja : SubclassMap<Bicikl>
    {
        public BiciklMapiranja()
        {
            DiscriminatorValue("BICIKL");
            Map(x => x.Ram, "VELICINA_RAMA");
        }
    }
    class SkuterMapiranja : SubclassMap<Skuter>
    {
        public SkuterMapiranja()
        {
            DiscriminatorValue("SKUTER");
            Map(x => x.Dozvola, "BROJ_DOZVOLE");
            Map(x => x.Registracija, "REGISTRACIONI_BROJ");
        }
    }
    class AutomobilMapiranja : SubclassMap<Automobil>
    {
        public AutomobilMapiranja()
        {
            DiscriminatorValue("AUTOMOBIL");
            Map(x => x.Dozvola, "BROJ_DOZVOLE");
            Map(x => x.Registracija, "REGISTRACIONI_BROJ");
        }
    }
}
