using AnimeProxyApi.Core.Application.Ports;
using Microsoft.AspNetCore.Mvc;

namespace AnimeProxy.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public sealed class AnimeController : ControllerBase
  {
    private readonly IAnimeRepository _repository;

    public AnimeController(IAnimeRepository repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var anime = await _repository.GetAsync();
      return Ok(anime);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
      var anime = await _repository.Get(id);
      if (anime != null)
      {
        return Ok(anime);
      }

      return NotFound(new { id });
    }
  }
}