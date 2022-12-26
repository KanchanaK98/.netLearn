using TaskAPI.Data;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class AuthorSQLServerService : IAuthorsRepository
    {
        private readonly TaskDBContext _context;
        public AuthorSQLServerService(TaskDBContext context)
        {
            _context = context;
        }
        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }
        public Author GetAuthor(int Id)
        {
            return _context.Authors.Find(Id);
        }
    }
}
