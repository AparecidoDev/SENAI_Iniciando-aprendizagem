using System;
using System.Collections.Generic;

#nullable disable

namespace senai_CZBooks_api.Domains
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdInstituicao { get; set; }
        public string NomeInstituicao { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
