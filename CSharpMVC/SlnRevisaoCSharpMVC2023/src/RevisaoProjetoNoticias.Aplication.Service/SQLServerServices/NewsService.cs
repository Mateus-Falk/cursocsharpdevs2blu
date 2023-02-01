﻿using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Domain.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Aplication.Service.SQLServerServices
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;
        public NewsService(INewsRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<NewsDTO> FindAll()
        {
            return _repository.FindAll()
                        .Select(n => new NewsDTO
                        {
                            id = n.Id,
                            title = n.Title,
                            description = n.Description,
                            categoryId = n.CategoryId,
                            createdOn = n.CreatedOn,
                            published = n.Published,
                            image = n.Image,
                            category = new CategoryDTO()
                            {
                                id= n.Category.Id,
                                name= n.Category.Name
                            }
                        }).ToList();
        }

        public async Task<NewsDTO> FindById(int id)
        {
            var dto = new NewsDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(NewsDTO dto)
        {
            if(dto.id > 0)
            {
                return _repository.Update(dto.mapToEntity());
            }
            else
            {
                return _repository.Save(dto.mapToEntity());
            }
        }

        public Task<int> SaveFile(int id, string fileName)
        {
            return _repository.SaveFile(id, fileName);
        }
    }
}
