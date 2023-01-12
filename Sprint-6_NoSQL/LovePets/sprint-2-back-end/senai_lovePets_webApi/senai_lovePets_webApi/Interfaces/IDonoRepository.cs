using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IDonoRepository
    {
        /// <summary>
        /// Lista todos os Donos
        /// </summary>
        /// <returns>Lista de Donos</returns>
        List<Dono> ListarTodos();

        /// <summary>
        /// Busca o dono através do seu id
        /// </summary>
        /// <param name="IdDono">Id do Dono que será Buscado</param>
        /// <returns>Um Dono encontrado</returns>
        Dono BuscarPorId(int IdDono);

        /// <summary>
        /// Cadastra um novo dono
        /// </summary>
        /// <param name="NovoDono">Objeto com as novas informações</param>
        void Cadastrar(Dono NovoDono);

        /// <summary>
        /// Atualiza as informações de um Dono existente
        /// </summary>
        /// <param name="IdDono">Id do dono que será Atualizado</param>
        /// <param name="DonoAtualizado">Objeto com as novas Informações</param>
        void Atualizar(int IdDono, Dono DonoAtualizado);

        /// <summary>
        /// Deleta um Dono exsistente
        /// </summary>
        /// <param name="IdDono">Id do dono que será deletado</param>
        void Deletar(int IdDono);
    }
}
