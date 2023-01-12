using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ISituacaoRepository
    {
        /// <summary>
        /// Lista todas as Situações
        /// </summary>
        /// <returns>Uma lista de Situações</returns>
        List<Situacao> ListarTodos();

        /// <summary>
        /// Busca um Situação através do seu ID
        /// </summary>
        /// <param name="IdSituacao">ID da Situação que será buscada</param>
        /// <returns>Uma Situação encontrada</returns>
        Situacao BuscarPorId(int IdSituacao);

        /// <summary>
        /// Cadastra uma nova Situação
        /// </summary>
        /// <param name="novaSituacao">Objeto com as novas informações</param>
        void Cadastrar(Situacao novaSituacao);

        /// <summary>
        /// Atualiza uma Situação existente
        /// </summary>
        /// <param name="IdSituacao">ID da Situação que será atualizada</param>
        /// <param name="SituacaoAtualizada">Objeto com as novas informações</param>
        void Atualizar(int IdSituacao, Situacao SituacaoAtualizada);

        /// <summary>
        /// Deleta uma Situação existente
        /// </summary>
        /// <param name="IdSituacao">ID da Situaçao que será deletada</param>
        void Deletar(int IdSituacao);
    }
}
