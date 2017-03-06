using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTutorial.Entities
{
    public class Product
    {
        public virtual string productName { get; set; }
        public virtual int cost { get; set; }
        public virtual DateTime makeDate { get; set; }
        public virtual string company { get; set; }
        public virtual int amount { get; set; }
    }
}
