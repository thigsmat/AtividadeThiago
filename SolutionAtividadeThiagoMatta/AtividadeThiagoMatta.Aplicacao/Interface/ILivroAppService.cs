using AtividadeThiagoMatta.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeThiagoMatta.Aplicacao.Interface
{
    public interface ILivroAppService: IAppServiceBase<Livro>
    {
        IEnumerable<Livro> OrdenarPorNome(IEnumerable<Livro> livros);
    }
}
