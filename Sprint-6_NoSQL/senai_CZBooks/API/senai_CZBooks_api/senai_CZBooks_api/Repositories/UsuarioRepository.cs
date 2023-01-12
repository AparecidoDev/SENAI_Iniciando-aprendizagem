using senai_CZBooks_api.Contexts;
using senai_CZBooks_api.Domains;
using senai_CZBooks_api.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace senai_CZBooks_api.Repositories
{   /// <summary>
    /// Classe responsável pelo repositório dos Usuários
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        CZBooksContext ctx = new CZBooksContext();


        /// <summary>
        /// Cadastra um novo Usuário
        /// </summary>
        /// <param name="NovoUsuario"></param>
        public void Cadastrar(Usuario NovoUsuario)
        {
            ctx.Usuarios.Add(NovoUsuario);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todos os Usuários
        /// </summary>
        /// <returns>Uma lista de Usuários</returns>
        public List<Usuario> Listar()
        {
            return ctx.Usuarios
                .Select(u => new Usuario()
                {
                    IdUsuario = u.IdUsuario,
                    NomeUsuario = u.NomeUsuario,
                    Email = u.Email,
                    IdTipoUsuario = u.IdTipoUsuario,

                    IdTipoUsuarioNavigation = new TipoUsuario()
                    {
                        IdTipoUsuario = u.IdTipoUsuarioNavigation.IdTipoUsuario,
                        TituloTipoUsuario = u.IdTipoUsuarioNavigation.TituloTipoUsuario
                    }
                })
                .ToList();
        }
    }
}
