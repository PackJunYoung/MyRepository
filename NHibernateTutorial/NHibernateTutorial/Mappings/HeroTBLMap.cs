using FluentNHibernate.Mapping;
using NHibernateTutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTutorial.Mappings
{
    public class HeroTBLMap : ClassMap<HeroTBL>
    {
        public HeroTBLMap()
        {
            Id(x => x.Id).GeneratedBy.Increment();
            Map(x => x.Name);

            Table("herotbl");
        }
    }
}
