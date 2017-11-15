using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Movimentacao.Infrastructure;
using Movimentacao.Models;
using NHibernate;

namespace Movimentacao.DataAccess
{
    public class MarcaAccess
    {

        public void Adiciona(Marca obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Save(obj);
                tx.Commit();
            }
        }

        public Marca BuscaPorId(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<Marca>(id);
            }
        }

        public void Remove(Marca obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public void Atualiza(Marca obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public void Grava(Marca obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public IList<Marca> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                string hql = "select p from Marca p";
                IQuery query = session.CreateQuery(hql);
                return query.List<Marca>();
            }
        }

    }
}