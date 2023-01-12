using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class PetRepository : IPetRepository
    {
        public void Atualizar(int IdPet, Pet PetAtualizado)
        {
            throw new NotImplementedException();
        }

        public Pet BuscarPorId(int IdPet)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Pet NovoPet)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int IdPet)
        {
            throw new NotImplementedException();
        }

        public List<Pet> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
