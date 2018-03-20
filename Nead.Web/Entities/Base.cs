using System;
using System.ComponentModel.DataAnnotations;

namespace Nead.Web.Entities
{
    public abstract class Base
    {
        public long Id { get; set; }

        [MaxLength(14)]
        public string UsuarioCriacao { get; set; }

        [MaxLength(14)]
        public string UsuarioAlteracao { get; set; }

        public DateTime? DataCriacao { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
