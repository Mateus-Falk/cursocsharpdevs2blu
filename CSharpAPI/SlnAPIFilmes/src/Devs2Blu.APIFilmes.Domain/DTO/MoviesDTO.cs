using Devs2Blu.APIFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.APIFilmes.Domain.DTO
{
    public class MoviesDTO
    {
        public int id { get; set; }
        public string title{ get; set; }
        public string description { get; set; }
        public int rating { get; set; }

        public Movies mapToEntity()
        {
            return new Movies
            {
                Id = id,
                Title = title,
                Description = description,
                Rating = rating
            };
        }
        public MoviesDTO mapToDTO(Movies movies)
        {
            return new MoviesDTO()
            {
                id = movies.Id,
                title = movies.Title,
                description = movies.Description,
                rating = movies.Rating
            };
        }
    }
}
