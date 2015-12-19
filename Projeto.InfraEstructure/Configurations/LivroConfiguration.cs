using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //entidades..
using System.Data.Entity.ModelConfiguration; //mapeamento..

namespace Projeto.InfraEstructure.Configurations
{
    //mapeamento da entidade Livro..
    public class LivroConfiguration : EntityTypeConfiguration<Livro>
    {
        //construtor..
        public LivroConfiguration()
        {
            ToTable("LIVRO"); //nome da tabela..

            HasKey(l => l.IdLivro); //chave primária..

            Property(l => l.IdLivro)
                .HasColumnName("IDLIVRO")
                .IsRequired();

            Property(l => l.Titulo)
                .HasColumnName("TITULO")
                .HasMaxLength(50)
                .IsRequired();

            Property(l => l.Resumo)
                .HasColumnName("RESUMO")
                .IsRequired();

            Property(l => l.Foto)
                .HasColumnName("FOTO")
                .HasMaxLength(50)
                .IsRequired();

            Property(l => l.Categoria)
                .HasColumnName("CATEGORIA")
                .IsRequired();

            Property(l => l.IdAutor)
                .HasColumnName("IDAUTOR")
                .IsRequired();

            #region Mapeamento dos Relacionamentos

            HasRequired(l => l.Autor) //livro TEM 1 Autor
                .WithMany(a => a.Livros) //autor TEM Muitos Livros
                .HasForeignKey(l => l.IdAutor); //Chave estrangeira

            #endregion
        }
    }
}
