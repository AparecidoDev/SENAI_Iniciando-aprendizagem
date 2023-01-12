using senai_CZBooks_api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_CZBooks_api.Interfaces
{
    interface IInstituicaoRepository
    {
        /// <summary>
        /// Lista todos as Instituições
        /// </summary>
        /// <returns>Uma lista de Instituiçõess</returns>
        List<Instituicao> Listar();

        /// <summary>
        /// Cadastra um nova Instituição
        /// </summary>
        /// <param name="NovaInstituicao">Objeto NovaInstituicao que será cadastrada</param>
        void Cadastrar(Instituicao NovaInstituicao);
    }
}

