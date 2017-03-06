using FluentNHibernate.Mapping;
using NHibernateTutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTutorial.Mappings
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Id(x => x.productName);
            Map(x => x.cost);
            Map(x => x.makeDate);
            Map(x => x.company);
            Map(x => x.amount);

            Table("producttbl");
        }
    }
}
