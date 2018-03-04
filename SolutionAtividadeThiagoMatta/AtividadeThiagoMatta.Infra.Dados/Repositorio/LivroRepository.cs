using AtividadeThiagoMatta.Dominio.Entities;
using AtividadeThiagoMatta.Dominio.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeThiagoMatta.Infra.Dados.Repositorio
{
    public class LivroRepository : RepositoryBase<Livro>, ILivroRepository
    {
        public IEnumerable<Livro> OrdenarPorNome(IEnumerable<Livro> livros)
        {
            return livros.OrderBy(l => l.Titulo);
        }
    }
}
