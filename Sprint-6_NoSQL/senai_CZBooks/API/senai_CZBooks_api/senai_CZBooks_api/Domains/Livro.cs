using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_CZBooks_api.Domains
{
    public partial class Livro
    {
        public Livro()
        {
            CategoriaLivros = new HashSet<CategoriaLivro>();
        }

        public int IdLivro { get; set; }
        public int? IdAutor { get; set; }
        public int? IdInstituicao { get; set; }
        public string Titulo { get; set; }

        [Required(ErrorMessage ="O nome do Livro é obrigatório")]
        public string Sinopse { get; set; }

        [Required(ErrorMessage = "A data de publicação é obrigatória")]
        public DateTime DataPublicacao { get; set; }

        [Required(ErrorMessage = "Informe o preço do livro")]
        public decimal? Preco { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Instituicao IdInstituicaoNavigation { get; set; }
        public virtual ICollection<CategoriaLivro> CategoriaLivros { get; set; }
    }
}
