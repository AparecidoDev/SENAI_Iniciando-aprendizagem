using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface ITipoPetRepository
    {
        /// <summary>
        /// Lista todos os Tipos de Pets
        /// </summary>
        /// <returns>Uma Lista de Tipos de Pets</returns>
        List<TipoPet> ListarTodos();

        /// <summary>
        /// Busca um Tipo de Pet através do seu Id
        /// </summary>
        /// <param name="IdTipoPet">Id do TipoPet que será buscado</param>
        /// <returns>Um TipoPet encontrado</returns>
        TipoPet BuscarPorId(int IdTipoPet);


        /// <summary>
        /// Cadastra um novo TipoPet
        /// </summary>
        /// <param name="NovoTipoPet">Objeto com as novas informações</param>
        void Cadastrar(TipoPet NovoTipoPet);

        /// <summary>
        /// Atualiza um TipoPet existente
        /// </summary>
        /// <param name="IdTipoPet">Id do TipoPet que será Atualizado</param>
        /// <param name="TipoPetAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdTipoPet, TipoPet TipoPetAtualizado);

        /// <summary>
        /// Deleta um TipoPet Existente
        /// </summary>
        /// <param name="IdTipoPet">Id do TipoPet que será deletado</param>
        void Deletar(int IdTipoPet);
    }
}
