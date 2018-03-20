using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nead.Web.Models
{
    public class LoginDto
    {
        public string Cpf { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public bool Lembrar { get; set; }
    }
}
