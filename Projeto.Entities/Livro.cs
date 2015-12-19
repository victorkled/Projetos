using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities.Types;

namespace Projeto.Entities
{
    public class Livro
    {
        public virtual int IdLivro { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Resumo { get; set; }
        public virtual string Foto { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual int IdAutor { get; set; }

        #region Relacionamentos

        public virtual Autor Autor { get; set; }

        #endregion
    }
}
