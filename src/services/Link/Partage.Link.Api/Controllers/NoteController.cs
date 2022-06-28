using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Partage.Link.Api
{
    [Route("link")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        public NoteController()
        {

        }

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(new LinkModel { Content = "Content Link", Id = 1 });
        }
    }

    class LinkModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
    }
}
