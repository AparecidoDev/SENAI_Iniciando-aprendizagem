using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IRacaRepository
    {
        /// <summary>
        /// Lista todas as Raças
        /// </summary>
        /// <returns>Lista de Raças</returns>
        List<Raca> ListarTodos();

        /// <summary>
        /// Busca o Raça através do seu id
        /// </summary>
        /// <param name="IdRaca">Id do Raça que será Buscada</param>
        /// <returns>Um Raça encontrada</returns>
        Pet BuscarPorId(int IdRaca);

        /// <summary>
        /// Cadastra uma nova Raça
        /// </summary>
        /// <param name="NovaRaca">Objeto com as novas informações</param>
        void Cadastrar(Raca NovaRaca);

        /// <summary>
        /// Atualiza as informações de uma Raça existente
        /// </summary>
        /// <param name="IdRaca">Id da Raça que será Atualizada</param>
        /// <param name="RacaAtualizada">Objeto com as novas Informações</param>
        void Atualizar(int IdRaca, Raca RacaAtualizada);

        /// <summary>
        /// Deleta uma Raça exsistente
        /// </summary>
        /// <param name="IdRaca">Id da Raca que será deletada</param>
        void Deletar(int IdRaca);
    }
}
