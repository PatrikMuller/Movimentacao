using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movimentacao.Models
{
    public class Bem
    {

        public virtual int IdBem { get; set; }
        public virtual string Tombo { get; set; }
        public virtual string Descricao { get; set; }
        public Modelo Modelo { get; set; }
        public Marca Marca { get; set; }

    }
}