using Devs2Blu.APIFilmes.Domain.DTO;
using Devs2Blu.APIFilmes.Domain.Entities;
using Devs2Blu.APIFilmes.Domain.IRepositories;
using Devs2Blu.APIFilmes.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.APIFilmes.Application.Services.SQLServerServices
{
    public class MoviesService : IMoviesService
    {
        private readonly IMoviesRepository _repository;
        public MoviesService(IMoviesRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Delete(int id)
        {
            var dto = await _repository.FindById(id);
            return await _repository.Delete(dto);
        }

        public List<MoviesDTO> FindAll()
        {
            return _repository.FindAll()
                                .Select(m => new MoviesDTO()
                                {
                                    id = m.Id,
                                    title = m.Title,
                                    description = m.Description,
                                    rating = m.Rating,
                                }).ToList();
        }

        public async Task<MoviesDTO> FindById(int id)
        {
            var dto = new MoviesDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(MoviesDTO movies)
        {
            if (movies.id > 0)
            {
                return _repository.Update(movies.mapToEntity());
            }
            else
            {
                return _repository.Save(movies.mapToEntity());
            }
        }
    }
}
