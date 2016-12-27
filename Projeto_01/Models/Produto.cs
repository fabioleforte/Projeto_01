using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto_01.Models
{
    public class Produto
    {
        [Display(Name = "Código do Produto")]
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }

        public long? CategoriaId { get; set; }
        public long? FabricanteId { get; set; }

        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}