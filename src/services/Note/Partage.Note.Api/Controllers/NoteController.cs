using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Partage.Note.Api
{
    [Route("note")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        public NoteController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(new NoteModel { Content = "Content Note", Id = 1 });
        }

        [HttpGet("lol")]
        public IActionResult GetLol()
        {
            return new OkObjectResult("lol");
        }
    }
}
