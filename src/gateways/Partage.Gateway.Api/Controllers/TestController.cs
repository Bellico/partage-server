using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Partage.Gateway.Api.Application;

[Route("note")]
[ApiController]
public class TestController : ControllerBase
{
    private readonly INoteService noteService;

    public TestController(INoteService noteService)
    {
        this.noteService = noteService;
    }

    // GET /api/test/3
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var value = await noteService.GetAsync();

        return new OkObjectResult(value);
    }
}
