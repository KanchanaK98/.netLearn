using TaskAPI.Models;

namespace TaskAPI.Services
{
    public interface IAuthorsRepository
    {
        public List<Author> GetAllAuthors();
        public Author GetAuthor(int Id);
    }
}
