using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Movimentacao.Infrastructure;
using Movimentacao.Models;
using NHibernate;
using NHibernate.Linq;

namespace Movimentacao.DataAccess
{
    public class BemAccess
    {


        public void Adiciona(Bem obj)
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
                //return session.Get<Bem>(id);
                Bem obj = session.Get<Bem>(id);
                return obj;

            }
        }

        public void Remove(Bem obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public void Atualiza(Bem obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public void Grava(Bem obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public IList<Bem> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                //string hql = "select p from Bem p ";
                //IQuery query = session.CreateQuery(hql);
                //return query.List<Bem>();

                //return = session.Query<Bem>().ToList();
                                                
                //return (from b in session.Query<Bem>().ToList()
                //           join ma in session.Query<Marca>().ToList() on b.Marca.IdMarca equals ma.IdMarca
                //           join mo in session.Query<Modelo>().ToList() on b.Modelo.IdModelo equals mo.IdModelo
                //           select b).ToList();

                return session.Query<Bem>().Fetch(b => b.Marca).Fetch(b => b.Modelo).OrderBy(b => b.IdBem).ToList();
                
            }
        }


    }
}