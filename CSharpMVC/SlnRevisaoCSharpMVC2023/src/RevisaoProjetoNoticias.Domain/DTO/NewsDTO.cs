using RevisaoProjetoNoticias.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Domain.DTO
{
    public class NewsDTO
    {
        [DisplayName("Id")]
        public int id { get; set; }

        [Required(ErrorMessage = "Set a title, please.")]
        [MinLength(3,ErrorMessage = "Title should be bigger than 3 characters")]
        [DisplayName("Title")]
        public string title { get; set; }

        [DisplayName("Description")]
        public string description { get; set; }

        [DisplayName("Category")]
        public int categoryId { get; set; }
        
        [DisplayName("Created On")]
        public DateTime? createdOn { get; set; }
        
        [DisplayName("Published")]
        public bool published { get; set; }
        [DisplayName("Image")]
        public string? image { get; set; }
        
        public virtual CategoryDTO? category { get; set; }

        public News mapToEntity()
        {
            return new News()
            {
                Id = id,
                Title = title,
                Description = description,
                CategoryId = categoryId,
                CreatedOn = createdOn,
                Published = published,
                Image = image
            };
        }
        public NewsDTO mapToDTO(News news)
        {
            return new NewsDTO()
            {
                id = news.Id,
                title = news.Title,
                description = news.Description,
                categoryId = news.CategoryId,
                createdOn = news.CreatedOn,
                published = news.Published,
                image = news.Image
                /*category = new CategoryDTO()
                {
                    id = news.Category.Id,
                    name= news.Category.Name
                }*/
            };
        }
    }
}
