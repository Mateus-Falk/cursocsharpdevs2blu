using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using Devs2Blu.ProjetosAula.Atividade4MVC.Repository;
using Devs2Blu.ProjetosAula.Atividade4MVC.Services.Interfeces;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Services.Implements
{
	public class JogosServices : IJogosService
	{
		private readonly JogoRepository _repository;
		public JogosServices(JogoRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(Jogo jogo)
		{
			return await _repository.DeleteJogo(jogo);
		}

		public async Task<Jogo> FindById(int id)
		{
			return await _repository.FindByIdJogo(id);
		}

		public async Task<IEnumerable<Jogo>> GetAllJogos()
		{
			return await _repository.GetAll();
		}

		async Task<int> IJogosService.Save(Jogo jogo)
		{
			return await _repository.SaveJogo(jogo);
		}
	}
}
