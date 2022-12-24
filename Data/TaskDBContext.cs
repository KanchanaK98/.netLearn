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
        public DbSet<Models.Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Task>().HasData(new Models.Task[]
            {
                 new Models.Task{Id = 1,Todo = "Complete Java OOP Assignment",Due = DateTime.Now.AddDays(2),Status = Models.TaskStatusEnum.Completed,AuthordID=1},
                new Models.Task{Id = 2,Todo = "Complete Database Assignment",Due = DateTime.Now.AddDays(3),Status = Models.TaskStatusEnum.InProgress,AuthordID=1},
                new Models.Task{Id = 3,Todo = "Complete XML Tutorial",Due = DateTime.Now.AddDays(6),Status = Models.TaskStatusEnum.Completed,AuthordID=2},
            }
            );

            modelBuilder.Entity<Models.Author>().HasData(new Models.Author[]
            {
                new Models.Author{Id = 1, FullName = "Kanchana Kariyawasam"},
                new Models.Author{Id = 2, FullName = "Buddhini Perera"},
                new Models.Author{Id = 3, FullName = "Sasindu Kariyawasam"},
                new Models.Author{Id = 4, FullName = "Parakrama Kariyawasam"},
            }
           );
        }
    }
}
