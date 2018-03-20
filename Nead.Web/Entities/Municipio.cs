using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nead.Web.Entities
{
    public class Municipio: Base
    {
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(2)]
        public string Uf { get; set; }
    }
}
