using senai_CZBooks_api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_api.Interfaces
{
    interface ILivroRepository
    {
        /// <summary>
        /// Lista todos os Livros
        /// </summary>
        /// <returns>Uma lista de Livros</returns>
        List<Livro> Listar();

        /// <summary>
        /// Cadastra um novo Livro
        /// </summary>
        /// <param name="NovoLivro">Objeto NovoLivro que será cadastrado</param>
        void Cadastrar(Livro NovoLivro);
    }
}

