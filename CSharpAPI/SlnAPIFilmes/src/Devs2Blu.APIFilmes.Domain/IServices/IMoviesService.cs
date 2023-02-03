using Devs2Blu.APIFilmes.Domain.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.APIFilmes.Domain.IServices
{
    public interface IMoviesService
    {
        List<MoviesDTO> FindAll();
        Task<MoviesDTO> FindById(int id);
        Task<int> Save(MoviesDTO movies);
        Task<int> Delete(int id);
    }
}
