using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Movimentacao.Infrastructure;
using Movimentacao.Models;
using NHibernate;

namespace Movimentacao.DataAccess
{
    public class ModeloAccess
    {

        public void Adiciona(Modelo obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Save(obj);
                tx.Commit();
            }
        }

        public Bem BuscaPorId(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<Bem>(id);
            }
        }

        public void Remove(Modelo obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public void Atualiza(Modelo obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public void Grava(Modelo obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public IList<Modelo> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                string hql = "select p from Modelo p";
                IQuery query = session.CreateQuery(hql);
                return query.List<Modelo>();
            }
        }

    }
}