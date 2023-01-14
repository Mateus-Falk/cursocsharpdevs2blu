using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Services.Interfeces
{
	public interface IJogosService
	{
		Task<IEnumerable<Jogo>> GetAllJogos();
		Task<int> Save(Jogo jogo);
		Task<int> Delete(Jogo jogo);
		Task<Jogo> FindById(int id);

	}
}
