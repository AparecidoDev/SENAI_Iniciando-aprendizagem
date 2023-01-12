using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Lista todos os Tipo de Usuários
        /// </summary>
        /// <returns>Uma Lista de Tipo de Usuários</returns>
        List<TipoUsuario> ListarTodos();

        /// <summary>
        /// Busca um Tipo de Usuário através do seu Id
        /// </summary>
        /// <param name="IdTipoUsuario">Id do Tipo de Usuario que será buscado</param>
        /// <returns>Um tipo encontrado</returns>
        TipoUsuario BuscarPorId(int IdTipoUsuario);

        /// <summary>
        /// Cadastra um novo Tipo de Usuário
        /// </summary>
        /// <param name="NovoTipoUsuario">Objeto com as novas informações</param>
        void Cadastrar(TipoUsuario NovoTipoUsuario);

        /// <summary>
        /// Atualiza um Tipo de Usuário existente
        /// </summary>
        /// <param name="IdTipoUsuario">Id do Tipo de Usuário que será Atualizado</param>
        /// <param name="TipoUsuarioAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdTipoUsuario, TipoUsuario TipoUsuarioAtualizado);

        /// <summary>
        /// Deleta um Tipo de Usuário Existente
        /// </summary>
        /// <param name="IdTipoUsuario">Id do Tipo de Usuário que será deletado</param>
        void Deletar(int IdTipoUsuario);
    }
}
