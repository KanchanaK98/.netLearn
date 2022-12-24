using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class DummyData : ITasksRepository
    {
        public List<Models.Task> TaskList()
        {
            var tasks = new List<Models.Task>();
            var task1 = new Models.Task()
            {
                Id = 1,
                Todo = "Complete Java OOP Assignment From Dummy Data",
                Due = DateTime.Now.AddDays(2),
                Status = Models.TaskStatusEnum.Completed,
            };
            tasks.Add(task1);

            var task2 = new Models.Task()
            {
                Id = 2,
                Todo = "Complete Graphics Assignment From Dummy Data",
                Due = DateTime.Now.AddDays(5),
                Status = Models.TaskStatusEnum.InProgress,
            };
            tasks.Add(task2);

            var task3 = new Models.Task()
            {
                Id = 3,
                Todo = "Complete Database Stored Proc Tutorial From Dummy Data",
                Due = DateTime.Now.AddDays(3),
                Status = Models.TaskStatusEnum.Completed,
            };
            tasks.Add(task3);
            return tasks;
        }
    }
}
