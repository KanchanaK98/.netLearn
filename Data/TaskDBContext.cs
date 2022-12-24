using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.Data
{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options) //used to options like set connection strings
            :base(options)
        {
        
        }

        public DbSet<Models.Task> Tasks { get; set;}  // Make a entity(table) called Tasks by using DbContext
                                               // Task is represent the Task model

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Task>().HasData(new Models.Task
            {
                 
                Id = 1,
                Todo = "Complete Java OOP Assignment",
                Due = DateTime.Now.AddDays(2),
                Status = Models.TaskStatusEnum.Completed,
            
            }
            );
        }
    }
}
