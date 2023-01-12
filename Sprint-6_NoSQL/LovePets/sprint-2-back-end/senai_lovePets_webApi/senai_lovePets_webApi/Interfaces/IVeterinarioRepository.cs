using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IVeterinarioRepository
    {
        /// <summary>
        /// Busca um Veterinário através do seu Id
        /// </summary>
        /// <param name="IdVeterinario">Id do veterinário que será buscado</param>
        /// <returns>Um Veterinário encontrado</returns>
        Veterinario BuscarPorId(int IdVeterinario);

        /// <summary>
        /// Cadastra um novo Veterinário
        /// </summary>
        /// <param name="NovoVeterinario">Objeto com as novas Informações</param>
        void Cadastrar(Veterinario NovoVeterinario);


        /// <summary>
        /// lista todos os Veterinários
        /// </summary>
        /// <returns>Uma lista de Veterinários</returns>
        List<Veterinario> ListarTodos();

        /// <summary>
        /// Atualiza um Veterinario existente
        /// </summary>
        /// <param name="IdVeterinario">Id do Veterinário que será Atualizado</param>
        /// <param name="VeterinarioAtualizado">Objeto com as novas informações</param>
        void Atualizar(int IdVeterinario, Veterinario VeterinarioAtualizado);

        /// <summary>
        /// Deleta um Veterinário existente
        /// </summary>
        /// <param name="IdVeterinario">Id do Veterinário que será deletado</param>
        void Deletar(int IdVeterinario);
    }
}
