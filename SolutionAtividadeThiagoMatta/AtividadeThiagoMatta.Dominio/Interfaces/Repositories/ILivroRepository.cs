using AtividadeThiagoMatta.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeThiagoMatta.Dominio.Interfaces.Repositories
{
    public interface ILivroRepository : IRepositoryBase<Livro>
    {
        IEnumerable<Livro> OrdenarPorNome(IEnumerable<Livro> livros);
    }
}
