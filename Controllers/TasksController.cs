using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")] // class level attribute
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var strArray = new string[] { "Task 1", "Task 2", "Task 3" };
            return Ok(strArray);
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            
            return new JsonResult(new { message = "completed", welcome="helo Kanchana" });
         }

        [HttpDelete]
        public IActionResult DeleteTask(int number)
        {
            string n;
            if (number==1)
            {
                n = "Number 1";
                return Ok(n);
            }
            n = "Number 0";
            return BadRequest(n);
        }
    }
}
