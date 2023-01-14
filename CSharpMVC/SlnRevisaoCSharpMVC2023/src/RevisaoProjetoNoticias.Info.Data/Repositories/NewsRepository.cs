using RevisaoProjetoNoticias.Domain.Entities;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Info.Data.Context;

namespace RevisaoProjetoNoticias.Info.Data.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        private readonly SQLServerContext _context;
        public NewsRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
