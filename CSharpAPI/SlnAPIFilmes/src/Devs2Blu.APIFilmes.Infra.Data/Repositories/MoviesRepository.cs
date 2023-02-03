using Devs2Blu.APIFilmes.Domain.Entities;
using Devs2Blu.APIFilmes.Domain.IRepositories;
using Devs2Blu.APIFilmes.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.APIFilmes.Infra.Data.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly SQLServerContext _context;
        public MoviesRepository(SQLServerContext context)
        {
            _context = context;
        }
        public Task<int> Delete(Movies movies)
        {
            _context.Set<Movies>().Remove(movies);
            return _context.SaveChangesAsync();
        }

        public IEnumerable<Movies> FindAll()
        {
            return _context.Set<Movies>();
        }

        public async Task<Movies> FindById(int id)
        {
            return await _context.Set<Movies>().FindAsync(id);
        }

        public Task<int> Save(Movies movies)
        {
            _context.Set<Movies>().Add(movies);
            return _context.SaveChangesAsync();
        }

        public Task<int> Update(Movies movies)
        {
            try
            {
                _context.Set<Movies>().Update(movies);
                return _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                return _context.SaveChangesAsync();
            }
        }
    }
}
