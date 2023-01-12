using senai_lovePets_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Interfaces
{
    interface IClinicaRepository
    {
        /// <summary>
        /// Lista todos as Clínicas
        /// </summary>
        /// <returns>Lista com todas as Clínicas caso haja mais de uma</returns>
        List<Clinica> ListarTodos();

        /// <summary>
        /// Busca uma Clínica através do seu id
        /// </summary>
        /// <param name="idClinica">Id da clínica que será buscada</param>
        /// <returns>Clínica encontrada</returns>
        Clinica BuscarPorId(int idClinica);

        /// <summary>
        /// Cadastra uma nova Clínica
        /// </summary>
        /// <param name="NovaClinica">Objeto com as novas informações</param>
        void Cadastrar(Clinica NovaClinica);

        /// <summary>
        /// Atualiza uma Clínica existente
        /// </summary>
        /// <param name="idClinica">Id da clinica que será atualizada</param>
        /// <param name="ClinicaAtualizada">Objeto com as novas informações</param>
        void Atualizar(int idClinica, Clinica ClinicaAtualizada);

        /// <summary>
        /// Clínica que será Deletada
        /// </summary>
        /// <param name="IdClinica">Id da Clínica que será deletada</param>
        void Deletar(int IdClinica);
    }
}
