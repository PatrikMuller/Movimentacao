﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentNHibernate.Mapping;
using Movimentacao.Models;

namespace Movimentacao.Mapping
{
    public class MarcaMapping : ClassMap<Marca>
    {

        public MarcaMapping()
        {
            Id(o => o.IdMarca).GeneratedBy.Identity();
            Map(o => o.Descricao);
        }

    }
}