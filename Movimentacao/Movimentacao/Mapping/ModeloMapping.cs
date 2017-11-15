using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentNHibernate.Mapping;
using Movimentacao.Models;

namespace Movimentacao.Mapping
{
    public class ModeloMapping : ClassMap<Modelo>
    {

        public ModeloMapping()
        {
            Id(o => o.IdModelo).GeneratedBy.Sequence("Modelo_IdModelo_Seq");//.GeneratedBy.Identity();
            Map(o => o.Descricao);
        }

    }
}