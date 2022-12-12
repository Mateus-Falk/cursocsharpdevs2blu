using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2v2.Web.Models.Entities
{
    [Table("jogos")]
    public class Jogo
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("personagem")]
        [Display(Name = "Personagem Pricipal")]
        public string Personagem { get; set; }

        [Column("GeneroId")]
        [Display(Name = "Genero")]
        public int GeneroId { get; set; }
    }
}
