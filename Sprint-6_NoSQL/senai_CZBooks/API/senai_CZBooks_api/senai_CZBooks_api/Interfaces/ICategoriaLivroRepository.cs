using senai_CZBooks_api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_api.Interfaces
{
    interface ICategoriaLivroRepository
    {
        /// <summary>
        /// Lista todos as Categoria de Livros 
        /// </summary>
        /// <returns>Uma lista de Categoria de Livros </returns>
        List<CategoriaLivro> Listar();

        /// <summary>
        /// Cadastra um nova CategoriaLivro
        /// </summary>
        /// <param name="NovaCategoriaLivro">Objeto NovaCategoriaLivro que será cadastrada</param>
        void Cadastrar(CategoriaLivro NovaCategoriaLivro);
    }
}
