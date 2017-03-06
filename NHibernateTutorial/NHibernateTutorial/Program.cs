using FluentNHibernate.Cfg;
using MySql.Data.MySqlClient;
using NHibernate;
using NHibernate.Cfg;
using NHibernateTutorial.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NHibernateRepository<Member> memberRep = new NHibernateRepository<Member>();
                Member m1 = new Member() { memberName = "박명수", memberAddress = "봉천" };
                memberRep.Save(m1);

                /*NHibernateRepository<HeroTBL> heroRep = new NHibernateRepository<HeroTBL>();
                //HeroTBL h = new HeroTBL { Name = "조운" };
                //heroRep.Save(h);
                IList<HeroTBL> h = SessionManager.Instance.session.QueryOver<HeroTBL>().Where(x => x.Id == 2).List();
                h[0].Name = "유비";
                heroRep.Update(h[0]);*/

                /*Product p1 = new Product { productName = "전자렌지", amount = 90 };
                Product p2 = new Product { productName = "가습기", amount = 90 };

                NHibernateRepository<Product> productRep = new NHibernateRepository<Product>();
                productRep.SaveOrUpdate(p1);
                productRep.SaveOrUpdate(p2);
                IList<Product> pl = productRep.GetAll();
                for (int i = 0; i < pl.Count; i++)
                {
                    Product p = pl[i];
                    Console.WriteLine(string.Format("productName={0}, amount={1}", p.productName, p.amount));
                }

                Product pd = productRep.Get("가습기");
                Console.WriteLine(string.Format("productName={0}, amount={1}", pd.productName, pd.amount));

                ISession session = SessionManager.Instance.session;
                IList<Product> q = session.QueryOver<Product>().Where(x => x.amount > 50).List();
                for (int i = 0; i < q.Count; i++)
                {
                    Product p = q[i];
                    Console.WriteLine(string.Format("productName={0}, amount={1}", p.productName, p.amount));
                }*/
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            Console.ReadLine();
        }
    }

    public class Site
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}
