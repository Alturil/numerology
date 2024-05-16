using Microsoft.AspNetCore.Mvc;
using Numerology.Api.Models;
using Numerology.Api.Services;

namespace Numerology.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController(ILogger<PersonController> logger, IPersonService personService) : Controller
{
    private readonly ILogger<PersonController> _logger = logger;
    private readonly IPersonService _personService = personService;

    [HttpGet]
    [Route("/Person")]
    public ActionResult<PersonResult> GetPersonResult(
        [FromQuery] string name,
        [FromQuery] int dayOfBirth,
        [FromQuery] int monthOfBirth,
        [FromQuery] int yearOfBirth)
    {
        return _personService.GetPersonResult(name, dayOfBirth, monthOfBirth, yearOfBirth);
    }
}
