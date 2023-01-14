using Devs2Blu.ProjetosAula.Atividade4MVC.Models;
using Devs2Blu.ProjetosAula.Atividade4MVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.Atividade4MVC.Repository
{
	public class JogoRepository
	{
		private readonly ContextoDatabase _context;
		public JogoRepository(ContextoDatabase contexto)
		{
			_context = contexto;
		}
		public async Task<IEnumerable<Jogo>> GetAll()
		{
			return await _context.Jogo.ToListAsync();
		}

		public async Task<int> SaveJogo(Jogo jogo)
		{
			_context.Add(jogo);
			return await _context.SaveChangesAsync();
		}

		internal async Task<int> DeleteJogo(Jogo jogo)
		{
			_context.Jogo.Remove(jogo);
			return await _context.SaveChangesAsync();
		}

		internal async Task<Jogo> FindByIdJogo(int id)
		{
			return await _context.Jogo.FindAsync(id);
		}
	}
}
