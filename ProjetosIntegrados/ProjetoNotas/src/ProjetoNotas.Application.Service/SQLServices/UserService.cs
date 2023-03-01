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
	public class UserService : IUserService
	{
		private readonly IUserRepository _repository;
		public UserService(IUserRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> Delete(int id)
		{
			return await _repository.Delete(await _repository.FindById(id));
		}

		public List<UserDTO> FindAll()
		{
			return _repository.FindAll()
								.Select(u => new UserDTO()
								{
									id = u.Id,
									name = u.Name,
									login = u.Login,
									password = u.Password,
								}).ToList();
		}

		public async Task<UserDTO> FindById(int id)
		{
			var dto = new UserDTO();
			return dto.mapToDTO(await _repository.FindById(id));
		}

		public Task<int> Save(UserDTO dto)
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
