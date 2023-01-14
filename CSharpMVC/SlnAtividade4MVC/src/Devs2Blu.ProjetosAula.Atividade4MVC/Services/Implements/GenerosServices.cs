using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using Devs2Blu.ProjetosAula.Atividade4MVC.Repository;
using Devs2Blu.ProjetosAula.Atividade4MVC.Services.Interfeces;
using System.Runtime.InteropServices;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Services.Implements
{
    public class GenerosServices : IGenerosService
    {
        private readonly GeneroRepository _repository;
        public GenerosServices(GeneroRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(Genero genero)
        {
            return await _repository.DeleteGenero(genero);
        }

        public async Task<Genero> FindById(int id)
        {
            return await _repository.FindByIdGenero(id);
        }

        public async Task<IEnumerable<Genero>> GetAllGeneros()
        {
            return await _repository.GetAll();
        }

		public async Task<int> Update(Genero genero)
		{
			return await _repository.UpdateGenero(genero);
		}

		async Task<int> IGenerosService.Save(Genero genero)
        {
            return await _repository.SaveGenero(genero);
        }
    }
}
