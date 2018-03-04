using AtividadeThiagoMatta.Dominio.Entities;
using System.Data.Entity.ModelConfiguration;

namespace AtividadeThiagoMatta.Infra.Dados.EntityConfig
{
    class LivroConfiguration : EntityTypeConfiguration<Livro>
    {
        public LivroConfiguration()
        {
            HasKey(c => c.LivroId);

            Property(c => c.Titulo)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Resumo)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}