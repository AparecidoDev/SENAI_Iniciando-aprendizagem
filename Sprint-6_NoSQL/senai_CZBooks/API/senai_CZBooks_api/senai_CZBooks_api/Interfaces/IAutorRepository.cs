using senai_CZBooks_api.Domains;
using System.Collections.Generic;

namespace senai_CZBooks_api.Interfaces
{
    interface IAutorRepository
    {
        /// <summary>
        /// Lista todos os Autores
        /// </summary>
        /// <returns>Uma lista de Autores</returns>
        List<Autor> Listar();

        /// <summary>
        /// Cadastra um novo Autor
        /// </summary>
        /// <param name="NovoAutor">Objeto NovoUsuario que será cadastrado</param>
        void Cadastrar(Autor NovoAutor);
    }
}

