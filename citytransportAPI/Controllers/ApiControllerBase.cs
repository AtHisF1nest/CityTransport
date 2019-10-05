using citytransportAPI.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace citytransportAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [ServiceFilter(typeof(SessionUsage))]
    public class ApiControllerBase : ControllerBase
    {

    }
}