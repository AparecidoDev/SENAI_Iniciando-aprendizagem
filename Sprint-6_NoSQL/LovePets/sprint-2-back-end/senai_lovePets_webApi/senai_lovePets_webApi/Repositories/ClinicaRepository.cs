using senai_lovePets_webApi.Contexts;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        /// <summary>
        /// instancia o objeto ctx ultilizando a classe lovePetsContext
        /// </summary>
        lovePetsContext ctx = new lovePetsContext();

        /// <summary>
        /// Atualiza uma Clínica existente
        /// </summary>
        /// <param name="idClinica">Id da clinica que será atualizada</param>
        /// <param name="ClinicaAtualizada">Objeto com as novas informações</param>
        public void Atualizar(int idClinica, Clinica ClinicaAtualizada)
        {
            Clinica ClinicaBuscada = BuscarPorId(idClinica);

            if(ClinicaAtualizada.RazaoSocial != null)
            {
                ClinicaBuscada.RazaoSocial = ClinicaAtualizada.RazaoSocial;
            }

            if( ClinicaAtualizada.Cnpj != null)
            {
                ClinicaBuscada.Cnpj = ClinicaAtualizada.Cnpj;
            }

            if(ClinicaAtualizada.Endereco != null)
            {
                ClinicaBuscada.Endereco = ClinicaAtualizada.Endereco;
            }
            ctx.Clinicas.Update(ClinicaBuscada);
            ctx.SaveChanges();
        }


        /// <summary>
        /// Busca uma Clínica através do seu id
        /// </summary>
        /// <param name="idClinica">Id da clínica que será buscada</param>
        /// <returns>Clínica encontrada</returns>
        public Clinica BuscarPorId(int idClinica)
        {
            return ctx.Clinicas.Find(idClinica);
        }

        /// <summary>
        /// Cadastra uma nova Clínica
        /// </summary>
        /// <param name="NovaClinica">Objeto com as novas informações</param>
        public void Cadastrar(Clinica NovaClinica)
        {
            ctx.Clinicas.Add(NovaClinica);
            ctx.SaveChanges();
        }

        /// <summary>
        /// Clínica que será Deletada
        /// </summary>
        /// <param name="IdClinica">Id da Clínica que será deletada</param>
        public void Deletar(int IdClinica)
        {
            ctx.Clinicas.Remove(BuscarPorId(IdClinica));
            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos as Clínicas
        /// </summary>
        /// <returns>Lista com todas as Clínicas caso haja mais de uma</returns>
        public List<Clinica> ListarTodos()
        {
            return ctx.Clinicas.ToList();               
        }
    }
}
