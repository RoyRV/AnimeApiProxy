using AnimeAPI.Core.Application.Ports;
using Microsoft.AspNetCore.Mvc;

namespace AnimeAPI.Controllers
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
    public IActionResult Get()
    {
      var anime = _repository.Get();
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
       
      return NotFound(new { id = id });
    }
  }
}