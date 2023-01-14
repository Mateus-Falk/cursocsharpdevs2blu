using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Models.DTO
{
    public class GeneroViewModel
    {
        [Display(Name = "Código")]
        public int id { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        public Genero ToEntity()
        {
            return new Genero
            {
                Id = id,
                Nome = nome
            };
        }
    }
}
