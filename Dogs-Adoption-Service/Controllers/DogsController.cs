using Microsoft.AspNetCore.Mvc;

namespace Dogs_Adoption_Service.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
