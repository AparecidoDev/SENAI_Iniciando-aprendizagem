using senai_CZBooks_api.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace senai_CZBooks_api.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todos os Usuários
        /// </summary>
        /// <returns>Uma lista de Usuários</returns>
        List<Usuario> Listar();

        /// <summary>
        /// Cadastra um novo Usuário
        /// </summary>
        /// <param name="NovoUsuario">Objeto NovoUsuario que será cadastrado</param>
        void Cadastrar(Usuario NovoUsuario);
    }
}
