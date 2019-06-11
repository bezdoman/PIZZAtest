using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class VelicinaPizzeMapiranja:ClassMap<VelicinaPizze>
    {
        public VelicinaPizzeMapiranja()
        {
            Table("VELICINA_PIZZE");

            Id(x => x.Velicina, "VELICINA");

            Map(x => x.Bodovi, "BODOVI");
                            //VelicinaPizze-Sadrzi 1:N
            HasMany(x => x.Pizze).KeyColumn("VELICINA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
