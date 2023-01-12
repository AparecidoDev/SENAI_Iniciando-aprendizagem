using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_CZBooks_api.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Autors = new HashSet<Autor>();
        }

        public int IdUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }

        [Required(ErrorMessage ="Informe o nome de Usuário")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage ="Informe o E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Senha Obrigatória")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "A senha deve conter no mínimo 5 caracteres")]  ((Número mínimo de caracteres))
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; } 
        public virtual ICollection<Autor> Autors { get; set; }
    }
}
