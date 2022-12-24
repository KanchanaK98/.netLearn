using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")] // class level attribute
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksRepository dataService;
        public TasksController(ITasksRepository repository)
        {
            dataService = repository;
        }
        [HttpGet]
        public IActionResult GetTasks()
        {
            
            var tasks = dataService.TaskList();
            return Ok(tasks);
        }

        [HttpGet("{ID?}")]
        public IActionResult GetTasksByID(int? ID)
        {
            if( ID is null)
            {
                GetTasks();
            }
            
            var tasks = from task in dataService.TaskList()
                        where task.Id == ID
                        select task;
            //var tasks = dummyData.TaskList().Where(t => t.Id == ID);
            return Ok(tasks);
        }

        //[HttpGet("{Status:alpha}")]
        //public IActionResult GetTasksByStatus(TaskStatusEnum Status)
        //{
        //    
        //    var tasks = from task in dataService.TaskList()
        //                where task.Status == Status
        //                select task;
        //    return Ok(tasks);
        //}

    }
}
