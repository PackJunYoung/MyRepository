using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTutorial.Entities
{
    public class Member
    {
        public virtual int memberID { get; set; }
        public virtual string memberName { get; set; }
        public virtual string memberAddress { get; set; }
    }
}
