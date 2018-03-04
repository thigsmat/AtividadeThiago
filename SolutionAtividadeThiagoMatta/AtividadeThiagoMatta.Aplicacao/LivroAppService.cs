using AtividadeThiagoMatta.Aplicacao.Interface;
using AtividadeThiagoMatta.Dominio.Entities;
using AtividadeThiagoMatta.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeThiagoMatta.Aplicacao
{
    public class LivroAppService : AppServiceBase<Livro>, ILivroAppService
    {
        private readonly ILivroService _livroService;

        public LivroAppService(ILivroService livroService)
            : base(livroService)
        {
            _livroService = livroService;
        }
        public IEnumerable<Livro> OrdenarPorNome(IEnumerable<Livro> livros)
        {
            return _livroService.OrdenarLivroPorNome(livros);
        }
    }
}
