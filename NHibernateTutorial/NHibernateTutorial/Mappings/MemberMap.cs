using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateTutorial.Entities;

namespace NHibernateTutorial.Mappings
{
    public class MemberMap : ClassMap<Member>
    {
        public MemberMap()
        {
            Id(x => x.memberID).GeneratedBy.Increment();
            Map(x => x.memberName);
            Map(x => x.memberAddress);

            Table("membertbl");
        }
    }
}
