using senai_CZBooks_api.Domains;
using System.Collections.Generic;

namespace senai_CZBooks_api.Interfaces
{
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Lista todos os tipos de Usuários
        /// </summary>
        /// <returns>Uma lista de tipos de Usuários</returns>
        List<TipoUsuario> Listar();


        /// <summary>
        /// Cadastra um novo tipo de Usuário
        /// </summary>
        /// <param name="NovoTipoUsuario">Objeto NovoTipoUsuario que será cadastrado</param>
        void Cadastrar(TipoUsuario NovoTipoUsuario);

    }
}
