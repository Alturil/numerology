﻿using Microsoft.AspNetCore.Mvc;
using Numerology.Api.Services;

namespace Numerology.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NumerologyController : Controller
{
    private readonly ILogger<NumerologyController> _logger;
    private readonly INameService _nameService;

    public NumerologyController(ILogger<NumerologyController> logger, INameService nameService)
    {
        _logger = logger;
        _nameService = nameService;
    }


    [HttpGet(Name = "NameInNumbers")]
    public ActionResult<List<int>> NameInNumbersAsync([FromQuery] string name)
    {
        return _nameService.GetNameNumbers(name);
    }
}
