using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentNHibernate.Mapping;
using Movimentacao.Models;

namespace Movimentacao.Mapping
{
    public class BemMapping : SubclassMap<Bem>
    {
        public BemMapping()
        {
            Id(o => o.IdBem).GeneratedBy.Sequence("Bem_IdBem_Seq");
            Map(o => o.Tombo);
            Map(o => o.Descricao);
        }

    }
}