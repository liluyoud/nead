using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nead.Web.Models
{
    public class RegisterDto
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Celular { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas estão diferentes.")]
        public string SenhaConfirmacao { get; set; }
    }
}
