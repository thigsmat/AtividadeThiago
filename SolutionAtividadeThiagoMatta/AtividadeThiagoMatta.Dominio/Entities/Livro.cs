using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeThiagoMatta.Dominio.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }

        public string Resumo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
