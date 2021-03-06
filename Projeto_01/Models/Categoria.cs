﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_01.Models
{
    public class Categoria
    {
        [Display(Name = "Código da Categoria")]
        public long CategoriaId { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}