using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using university_applications.Services;


namespace university_applications.Controllers
{
  [ApiController]
  [Route("university")]

  public class UniversityController : ControllerBase, IUniversityController
  {
    private readonly IUniversityService _universityService;

    public UniversityController(IUniversityService universityService)
    {
      _universityService = universityService;
    }

    [HttpGet("Country&Name")]
    public async Task<IActionResult> FindUniversity(string country, string name)
    {
      var university = await _universityService.FindUniversity(name, country);

      if (university == null)
      {
        return NotFound();
      }

      return Ok(university);
    }

    [HttpGet("Country")]
    public async Task<IActionResult> FindUniversity(string country)
    {
      var university = await _universityService.FindUniversity(country);

      if (university == null)
      {
        return NotFound();
      }

      return Ok(university);
    }

  }
}

