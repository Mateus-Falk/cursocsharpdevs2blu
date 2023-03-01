using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IRepository;
using ProjetoNotas.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNotas.Application.Service.SQLServices
{
	public class NoteService : INoteService
	{
		private readonly INoteRepository _repository;
		public NoteService(INoteRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			return await _repository.Delete(await _repository.FindById(id));
		}

		public List<NoteDTO> FindAll()
		{
			return _repository.FindAll()
						.Select(n => new NoteDTO()
						{
							id = n.Id,
							userId = n.UserId,
							title = n.Title,
							description = n.Description,
							category = n.Category,
							timeNote = n.TimeNote,
							Fixed = n.Fixed,
							user = new UserDTO()
							{
								id = n.User.Id,
								name = n.User.Name,
								login = n.User.Login,
								password = n.User.Password
							}
						}).ToList();
		}

		public async Task<NoteDTO> FindById(int id)
		{
			var dto = new NoteDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

		public Task<int> Save(NoteDTO dto)
		{
			if (dto.id > 0)
			{
				return _repository.Update(dto.mapToEntity());
			}
			else
			{
				return _repository.Save(dto.mapToEntity());
			}
		}
	}
}
