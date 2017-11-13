using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentNHibernate.Mapping;
using Movimentacao.Models;

namespace Movimentacao.Mapping
{
    public class BemMapping : ClassMap<Bem>
    {
        public BemMapping()
        {
            Id(o => o.IdBem).GeneratedBy.Identity();
            Map(o => o.Tombo);
            Map(o => o.Descricao);
            References(p => p.Modelo, "ModeloId");
            References(p => p.Marca, "MarcaId");
        }

    }
}