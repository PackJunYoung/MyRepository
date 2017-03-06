using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateTutorial
{
    class SessionManager
    {
        static SessionManager m_instance;
        static ISessionFactory m_sessionFactory;
        
        public static SessionManager Instance
        {
            get
            {
                if (m_instance == null)
                {
                    object sync = new object();
                    lock (sync)
                    {
                        m_instance = new SessionManager();
                    }
                }
                return m_instance;
            }
        } 

        public SessionManager()
        {
        }

        public ISession session
        {
            get
            {
                if (m_sessionFactory == null)
                {
                    object sync = new object();
                    lock (sync)
                    {
                        Configuration cfg = new Configuration();
                        cfg.Configure("hibernate.cfg.xml");
                        m_sessionFactory = Fluently.Configure(cfg).Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>()).BuildSessionFactory();
                    }                    
                }
                return m_sessionFactory.OpenSession();
            }
        }
    }
}
