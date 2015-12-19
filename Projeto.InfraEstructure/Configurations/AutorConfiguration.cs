using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //entidades..
using System.Data.Entity.ModelConfiguration; //mapeamento..

namespace Projeto.InfraEstructure.Configurations
{
    //mapeamento da entidade Autor..
    public class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        //construtor..
        public AutorConfiguration()
        {
            ToTable("AUTOR"); //nome da tabela..

            HasKey(a => a.IdAutor); //chave primária..

            Property(a => a.IdAutor)
                .HasColumnName("IDAUTOR")
                .IsRequired();

            Property(a => a.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
