using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using PIZZAtest.Entiteti;

namespace PIZZAtest.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            //Mapiranje tabele
            Table("ZAPOSLENI");

            DiscriminateSubClassesOnColumn("TIP_ZAPOSLENOG");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            
            //mapiranje svojstava
            Map(x => x.JMBG, "JMBG");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
           // Map(x => x.Tip, "TIP_ZAPOSLENOG");
            Map(x => x.Kategorija, "KATEGORIJA");
            //Zaposleni-Osoba 1:1
            References(x => x.LicniBroj).Column("LICNI_BROJ").LazyLoad();
                                //Zaposleni-RadiUSmeni 1:N
            HasMany(x => x.RadneNedelje).KeyColumn("ZAPOSLENI_ID").LazyLoad().Cascade.All().Inverse(); ;

        }

        public class DostavljacMapiranja : SubclassMap<Dostavljac>
        {
            public DostavljacMapiranja()
            {
                DiscriminatorValue("Dostavljac");
                                        //Dostavljac-Vozilo 1:N
                HasMany(x => x.Vozila).KeyColumn("ID_ZAPOSLENI").LazyLoad().Cascade.All().Inverse();
                                        //Dostavljac-Porudzbina 1:N
                HasMany(x => x.DostavljenePorudzbine).KeyColumn("ID_DOSTAVLJAC").LazyLoad().Cascade.All().Inverse();
            }
        }
        public class OperaterMapiranja : SubclassMap<Operater>
        {
            public OperaterMapiranja()
            {
                DiscriminatorValue("Operater");
                                    //Operater-StraniJezik 1:N
                HasMany(x => x.Jezici).KeyColumn("ZAPOSLENI_ID").LazyLoad().Cascade.All().Inverse();
                                    //Operater-Porudzbina 1:N
                HasMany(x => x.PrimljenePorudzbine).KeyColumn("ID_OPERATER").LazyLoad().Cascade.All().Inverse();
            }
        }
    }
}
