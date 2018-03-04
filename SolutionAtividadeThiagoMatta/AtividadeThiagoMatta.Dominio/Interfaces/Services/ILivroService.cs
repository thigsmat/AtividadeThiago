using AtividadeThiagoMatta.Dominio.Entities;
using System.Collections.Generic;

namespace AtividadeThiagoMatta.Dominio.Interfaces.Services
{
    public interface ILivroService : IServiceBase<Livro>
    {
        IEnumerable<Livro> OrdenarLivroPorNome(IEnumerable<Livro> livros);
    }
}
