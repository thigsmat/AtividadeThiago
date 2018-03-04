using System.Collections.Generic;
using AtividadeThiagoMatta.Dominio.Entities;
using AtividadeThiagoMatta.Dominio.Interfaces.Repositories;
using AtividadeThiagoMatta.Dominio.Interfaces.Services;

namespace AtividadeThiagoMatta.Dominio.Services
{
    public class LivroService : ServiceBase<Livro>, ILivroService
    {
        private readonly ILivroRepository _repository;

        public LivroService(ILivroRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Livro> OrdenarLivroPorNome(IEnumerable<Livro> livros)
        {
            return _repository.OrdenarPorNome(livros);
        }
    }
}
