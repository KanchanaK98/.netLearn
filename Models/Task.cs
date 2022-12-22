namespace TaskAPI.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Todo { get; set; }
        public DateTime Due { get; set; } 
        public TaskStatusEnum Status { get; set; }  //in progress , completed
    }


}
