using senai_CZBooks_api.Contexts;
using senai_CZBooks_api.Domains;
using senai_CZBooks_api.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace senai_CZBooks_api.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório dos Tipos de Usuarios
    /// </summary>
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {   /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        CZBooksContext ctx = new CZBooksContext();


        /// <summary>
        /// Cadastra um novo Usuário
        /// </summary>
        /// <param name="NovoUsuario">Objeto NovoUsuario que será cadastrado</param>
        public void Cadastrar(TipoUsuario NovoTipoUsuario)
        {
            ctx.TipoUsuarios.Add(NovoTipoUsuario);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos os Usuários
        /// </summary>
        /// <returns>Uma lista de Usuários</returns>
        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
