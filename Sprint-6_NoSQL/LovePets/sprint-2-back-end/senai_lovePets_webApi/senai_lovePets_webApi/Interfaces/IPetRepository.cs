using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IPetRepository
    {
        /// <summary>
        /// Lista todos os pets
        /// </summary>
        /// <returns>Lista de Pets</returns>
        List<Pet> ListarTodos();

        /// <summary>
        /// Busca o pet através do seu id
        /// </summary>
        /// <param name="IdPet">Id do pet que será Buscado</param>
        /// <returns>Um Pet encontrado</returns>
        Pet BuscarPorId(int IdPet);

        /// <summary>
        /// Cadastra um novo pet
        /// </summary>
        /// <param name="NovoPet">Objeto com as novas informações</param>
        void Cadastrar(Pet NovoPet);

        /// <summary>
        /// Atualiza as informações de um Pet existente
        /// </summary>
        /// <param name="IdPet">Id do pet que será Atualizado</param>
        /// <param name="PetAtualizado">Objeto com as novas Informações</param>
        void Atualizar(int IdPet, Pet PetAtualizado);

        /// <summary>
        /// Deleta um Pet exsistente
        /// </summary>
        /// <param name="IdPet">Id do Pet que será deletado</param>
        void Deletar(int IdPet);
    }
}
