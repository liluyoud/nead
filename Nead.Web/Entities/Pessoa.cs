using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nead.Web.Entities
{
    public class Pessoa : Base
    {
        [Required]
        [MaxLength(256)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(14)]
        public string Cpf { get; set; }

        [Required]
        [MaxLength(30)]
        public string Celular { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Perfil { get; set; }

        public virtual Municipio Municipio { get; set; }

        public byte[] Foto { get; set; }
    }
}
