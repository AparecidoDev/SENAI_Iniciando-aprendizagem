using System;
using System.Collections.Generic;

#nullable disable

namespace senai_CZBooks_api.Domains
{
    public partial class CategoriaLivro
    {
        public int IdCategoriaLivro { get; set; }
        public int? IdLivro { get; set; }
        public string NomeCategoria { get; set; }

        public virtual Livro IdLivroNavigation { get; set; }
    }
}
