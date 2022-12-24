using System.Diagnostics;

namespace TaskAPI.Services
{
    public interface ITasksRepository
    {
        public List<Models.Task> TaskList();
    }
}
