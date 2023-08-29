using Microsoft.AspNetCore.Mvc;

namespace BlazorApp6.Controllers
{
    public class MvcController : Controller
    {

        [Route("mvc")]
        public IActionResult Index()
        {
            return Redirect("https://www.microsoft.com");
            
        }
    }
}
