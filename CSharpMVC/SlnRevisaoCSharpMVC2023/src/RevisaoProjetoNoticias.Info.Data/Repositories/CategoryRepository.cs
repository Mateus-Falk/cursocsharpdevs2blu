using RevisaoProjetoNoticias.Domain.Entities;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Info.Data.Context;

namespace RevisaoProjetoNoticias.Info.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly SQLServerContext _context;
        public CategoryRepository(SQLServerContext context) : base(context)
        {
        }
    }
}
