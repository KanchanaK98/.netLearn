using System.ComponentModel.DataAnnotations;

namespace TaskAPI.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Todo { get; set; }
        public DateTime Due { get; set; } 
        public TaskStatusEnum Status { get; set; }  //in progress , completed
        public int AuthordID { get; set; }
    }


}
