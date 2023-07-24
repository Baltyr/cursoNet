using cursodotnet.Functions;
using cursodotnet.Models;
using Microsoft.AspNetCore.Mvc;

namespace cursodotnet.Controllers;

[ApiController]
[Route("api/cursonetcore/v1")]
public class CursoNetCoreController : ControllerBase
{
    private readonly IPersonaFunction _personaFunction;

    public CursoNetCoreController(IPersonaFunction personaFunction)
    {
        _personaFunction = personaFunction;
    }

    [HttpGet]
    public async Task<object> Get()
    {
        return await _personaFunction.GetApis();
    }
}
