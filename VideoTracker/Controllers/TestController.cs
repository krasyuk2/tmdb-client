using Microsoft.AspNetCore.Mvc;
using TmdbApi;

namespace VideoTracker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly ITmdbClient _tmdbClient;

    public TestController(ITmdbClient tmdbClient)
    {
        _tmdbClient = tmdbClient;
    }

    [HttpGet]
    public async Task<ActionResult> Get()
    {
        var result = await _tmdbClient.GetRequestMultiSearchAsync("");
        return Ok(result);
    }
}