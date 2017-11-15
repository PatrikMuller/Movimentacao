using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using System.Reflection;


namespace Movimentacao.Infrastructure
{
    public class NHibernateHelper
    {

        private static ISessionFactory factory = CriaSessionFactory();

        public static ISessionFactory CriaSessionFactory()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();

            ISessionFactory factory = Fluently.Configure(cfg).Mappings
                (x => { x.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()); }).BuildSessionFactory();

            return factory;
        }

        public static ISession AbreSessao()
        {
            return factory.OpenSession();
        }

    }
}