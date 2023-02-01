using RevisaoProjetoNoticias.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Domain.IService
{
    public interface INewsService : IBaseServices<NewsDTO>
    {
        Task<int> SaveFile(int id, string file);
    }
}
