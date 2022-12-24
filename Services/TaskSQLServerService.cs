using TaskAPI.Data;

namespace TaskAPI.Services
{
    public class TaskSQLServerService : ITasksRepository
    {
        private readonly TaskDBContext _context;
        public TaskSQLServerService(TaskDBContext context)
        {
            _context = context;
        }
        public List<Models.Task> TaskList()
        {
            return _context.Tasks.ToList();
        }
    }
}
