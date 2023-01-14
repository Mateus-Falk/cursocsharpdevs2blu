using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Services.Interfeces
{
    public interface IGenerosService
    {
        Task<IEnumerable<Genero>> GetAllGeneros();
        Task<int> Save(Genero genero);
        Task<int> Delete(Genero genero);
        Task<Genero> FindById(int id);
		Task<int> Update(Genero genero);
	}
}
