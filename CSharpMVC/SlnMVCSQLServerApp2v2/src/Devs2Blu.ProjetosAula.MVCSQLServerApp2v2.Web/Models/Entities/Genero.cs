using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2v2.Web.Models.Entities
{
    [Table("generos")]
    public class Genero
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name ="Nome")]
        public string Nome { get; set; }

       // public ICollection<Jogo> Jogos { get; set; }
    }
}
