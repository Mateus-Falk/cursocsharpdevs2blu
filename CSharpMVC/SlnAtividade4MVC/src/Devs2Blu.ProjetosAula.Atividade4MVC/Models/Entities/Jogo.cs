using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities
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
        
        [Column("personagem")]
        [Display(Name = "Personagem Principal")]
        public string Personagem { get; set; }
        
        [Column("review")]
        [Display(Name = "Review/Critíca")]
        public string Review { get; set; }
        
        [Column("nota")]
        [Display(Name = "Nota")]
        public double Nota { get; set; }

        [Column("GeneroId")]
        [Display(Name = "Genero")]
        public int GeneroId { get; set; }
        public virtual Genero? Genero { get; set; }
    }
}
