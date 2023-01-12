using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_lovePets_webApi.Domains;
using senai_lovePets_webApi.Interfaces;
using senai_lovePets_webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace senai_lovePets_webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicasController : ControllerBase
    {
        private IClinicaRepository _clinicaRepository { get; set; }

        public ClinicasController()
        {
            _clinicaRepository = new ClinicaRepository();
        }

        /// <summary>
        /// Busca uma clinica através do seu Id
        /// </summary>
        /// <param name="IdClinica">Id da clinica que será Buscada</param>
        /// <returns>Uma Clínica encontrada com Um Status code 200 - Ok</returns>
       [Authorize(Roles = "1")]
        [HttpGet("{IdClinica}")]
        public IActionResult BuscarPorId(int IdClinica)
        {
            try
            {
                return Ok(_clinicaRepository.BuscarPorId(IdClinica));
            }
            catch(Exception erro)
            {
                return BadRequest(erro);
            }

        }

       /// <summary>
       /// Lista todos as Clinicas
       /// </summary>
       /// <returns>Um status code 200 - Ok com o conteúdo da Lista</returns>
       [Authorize(Roles = "1")]
        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_clinicaRepository.ListarTodos());
            }
            catch(Exception erro)
            {
                return BadRequest(erro);
            }
        }


        /// <summary>
        /// Cadastra uma Nova Clinica
        /// </summary>
        /// <param name="NovaClinica">Onjeto com as novas Informações</param>
        /// <returns>Um status code 201 - Created</returns>
       [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Clinica NovaClinica)
        {
            try
            {
                _clinicaRepository.Cadastrar(NovaClinica);
                return StatusCode(201);
            }
            catch(Exception erro)
            {
                return BadRequest(erro);
            }
        }


        /// <summary>
        /// Atualiza uma Clinica 
        /// </summary>
        /// <param name="IdClinica">Id da Clínica que será Atualizada</param>
        /// <param name="ClinicaAtualizada">Objeto com as novas informações</param>
        /// <returns>Um Status code  204 - No Content</returns>
        [Authorize(Roles ="1")]
        [HttpPut("{IdClinica}")]
        public IActionResult Atualizar(int IdClinica , Clinica ClinicaAtualizada)
        {
            try
            {
                _clinicaRepository.Atualizar(IdClinica, ClinicaAtualizada);
                return NoContent();
            }
            catch( Exception erro)
            {
                return BadRequest(erro);
            }
        }

        /// <summary>
        /// Deleta uma Clinica Existente
        /// </summary>
        /// <param name="IdClinica">Id da clinica que será deletada</param>
        /// <returns>Um status code 204 - No Content</returns>
       [Authorize(Roles = "1")]
        [HttpDelete("{IdClinica}")]
        public IActionResult Deletar(int IdClinica)
        {
            try
            {
                _clinicaRepository.Deletar(IdClinica);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}
