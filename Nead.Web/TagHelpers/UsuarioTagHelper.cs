using Microsoft.AspNetCore.Razor.TagHelpers;
using Nead.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nead.Web.TagHelpers
{

    public class UsuarioTagHelper : TagHelper
    {
        private readonly NeadContext _contexto;

        public UsuarioTagHelper(NeadContext contexto)
        {
            _contexto = contexto;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {

        }
    }
}
