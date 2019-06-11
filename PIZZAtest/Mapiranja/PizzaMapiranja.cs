using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PIZZAtest.Entiteti;
using FluentNHibernate.Mapping;

namespace PIZZAtest.Mapiranja
{
    class PizzaMapiranja : ClassMap<Pizza>
    {
        public PizzaMapiranja()
        {
            Table("PIZZA");
            
            //mapiranje primarnog kljuca
            Id(x => x.Naziv, "NAZIV");

            //mapiranje svojstava
            Map(x => x.Cena, "CENA");

                                //Pizza-Dodaci 1:N
            HasMany(x => x.Sastojci).KeyColumn("NAZIV_PIZZE").LazyLoad().Cascade.All().Inverse();
                                //Pizza-Sadrzi 1:N
            HasMany(x => x.Narucene).KeyColumn("NAZIV_PIZZE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
