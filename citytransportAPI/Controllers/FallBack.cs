using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace citytransportAPI.Controllers
{
    public class FallBack : Controller
    {
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), 
                "wwwroot", "index.html"), "text/HTML");
        }
    }
}