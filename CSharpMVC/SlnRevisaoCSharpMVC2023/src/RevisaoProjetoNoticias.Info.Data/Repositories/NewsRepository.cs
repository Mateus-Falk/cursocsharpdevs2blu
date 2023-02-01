using Microsoft.EntityFrameworkCore;
using RevisaoProjetoNoticias.Domain.Entities;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Info.Data.Context;
using System.Xml.Schema;

namespace RevisaoProjetoNoticias.Info.Data.Repositories
{
    public class NewsRepository : BaseRepository<News>, INewsRepository
    {
        private readonly SQLServerContext _context;
        public NewsRepository(SQLServerContext context) : base(context)
        {
            this._context = context;
        }
        
        public async Task<int> SaveFile(int id, string fileName)
        {
            string sqlCommand = $"UPDATE [dbo].[News] SET Image = '{fileName}' WHERE Id = {id}";
            return await this.ExecuteCommand(sqlCommand);
        }
    /*    public async Task<int> SaveMultipleFiles(int id, string[] files)
        {
            foreach(var file in files)
            {
                var imgNews = new FileAttach()
                {
                    NewsId = id,
                    Image = file
                };
                this._context.Set<FileAttach>().Add(imgNews);
            }
            return await this._context.SaveChangesAsync();
        }*/
    }

   /* public class FileAttach
    {
        public int Id { get; set; }
        public int NewsId { get; set; }
        public string Image { get; set; }

    }*/
}
