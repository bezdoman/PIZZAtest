using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class PorudzbinaMapiranja:ClassMap<Porudzbina>
    {
        public PorudzbinaMapiranja()
        {
            Table("PORUDZBINA");

            DiscriminateSubClassesOnColumn("STANJE");

            Id(x => x.Idp, "IDP").GeneratedBy.TriggerIdentity();

          //  Map(x => x.Stanje, "STANJE");
            Map(x => x.DatumVremeKreiranja, "DATUM_VREME_KREIRANJA");
            Map(x => x.NacinPlacanja, "NACIN_PLACANJA");//  Map(x => x.NacinPlacanja, "NACIN_PLACNJA");

            References(x => x.IdKupca).Column("ID_KUPCA");
            References(x => x.IdOperater).Column("ID_OPERATER");

           

            //Porudzbina-Sadrzaj 1:N
            HasMany(x => x.Sadrzaj).KeyColumn("ID_PORUDZBINE").LazyLoad().Cascade.AllDeleteOrphan().Inverse();
        }
    }
    public class IsporucenaPorudzbinaMapiranja : SubclassMap<IsporucenaPorudzbina>
    {
        public IsporucenaPorudzbinaMapiranja()
        {
            DiscriminatorValue("Isporucena");
            Map(x => x.DatumVremeIsporuke, "DATUM_VREME_ISPORUKE");

            References(x => x.IdDostavljac).Column("ID_DOSTAVLJAC");
            References(x => x.IdVozilo).Column("ID_VOZILO");
        }
    }
    class NeisporucenaPorudzbinaMapiranja : SubclassMap<NeisporucenaPorudzbina>
    {
        public NeisporucenaPorudzbinaMapiranja()
        {
            DiscriminatorValue("Neisporucena");
        }
    }
}
