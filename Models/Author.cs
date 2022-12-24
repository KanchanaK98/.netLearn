using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }

    }
}
