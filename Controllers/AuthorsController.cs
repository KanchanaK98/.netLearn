using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]  // api/Authors
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorsRepository dataService;
        public AuthorsController(IAuthorsRepository repository)
        {
            dataService = repository;
        }
        [HttpGet]
        public IActionResult GetAuthor()
        {
            var authors = dataService.GetAllAuthors();
            return Ok(authors);
        }
        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            Models.Author authors = dataService.GetAuthor(id);
            if(authors == null)
            {
                return BadRequest("Not found author");
            }
            return Ok(authors);
        }
    }
}
