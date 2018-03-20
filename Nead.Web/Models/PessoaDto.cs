using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nead.Web.Models
{
    public class PessoaDto
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public long MunicipioId { get; set; }
    }
}
