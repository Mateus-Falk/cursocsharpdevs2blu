using Devs2Blu.ProjetosAula.Atividade4MVC.Models;
using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Repository
{
    public class GeneroRepository
    {
        private readonly ContextoDatabase _context;

        public GeneroRepository(ContextoDatabase context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Genero>> GetAll()
        {
            return await _context.Genero.ToListAsync();
        }

        public async Task<int> SaveGenero(Genero genero)
        {
            _context.Add(genero);
            return await _context.SaveChangesAsync();
        }

        internal async Task<int> DeleteGenero(Genero genero)
        {
            _context.Genero.Remove(genero);
            return await _context.SaveChangesAsync();
        }

        internal async Task<Genero> FindByIdGenero(int id)
        {
            return await _context.Genero.FindAsync(id);
        }

		internal Task<int> UpdateGenero(Genero genero)
		{
            _context.Genero.Update(genero);
            return _context.SaveChangesAsync();
		}
	}
}
