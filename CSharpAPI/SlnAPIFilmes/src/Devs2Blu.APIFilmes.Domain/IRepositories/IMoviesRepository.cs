using Devs2Blu.APIFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.APIFilmes.Domain.IRepositories
{
    public interface IMoviesRepository
    {
        IEnumerable<Movies> FindAll();
        Task<Movies> FindById(int id);
        Task<int> Save(Movies movies);
        Task<int> Update(Movies movies);
        Task<int> Delete(Movies movies);
    }
}
