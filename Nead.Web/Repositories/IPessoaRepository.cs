using Nead.Web.Entities;
using Nead.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nead.Web.Repositories
{
    public interface IPessoaRepository
    {
        IEnumerable<PessoaDto> Todos();

        Pessoa GetById(int id);

        void Add(PessoaDto pessoa);

        void Update(PessoaDto pessoa);
    }
}
