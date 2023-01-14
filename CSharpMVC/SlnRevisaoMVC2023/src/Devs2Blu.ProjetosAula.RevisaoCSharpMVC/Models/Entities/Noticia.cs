using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.RevisaoCSharpMVC.Models.Entities
{
    public class Noticia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [Column(TypeName = "TEXT")]
        public string Descricao { get; set; }
        public int? CategoriaId { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
