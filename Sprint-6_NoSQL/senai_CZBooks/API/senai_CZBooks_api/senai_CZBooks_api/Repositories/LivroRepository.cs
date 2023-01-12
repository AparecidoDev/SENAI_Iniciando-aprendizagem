using senai_CZBooks_api.Contexts;
using senai_CZBooks_api.Domains;
using senai_CZBooks_api.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace senai_CZBooks_api.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório dos Livros
    /// </summary>
    public class LivroRepository : ILivroRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        CZBooksContext ctx = new CZBooksContext();


        /// <summary>
        /// Cadastra um novo Livro
        /// </summary>
        /// <param name="NovoLivro"></param>
        public void Cadastrar(Livro NovoLivro)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Lista todos os Livros
        /// </summary>
        /// <returns>Uma Lista de Livros</returns>
        public List<Livro> Listar()
        {
            return ctx.Livros.ToList();
        }
    }
}
