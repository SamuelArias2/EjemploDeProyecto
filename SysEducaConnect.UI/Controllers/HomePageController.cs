using Microsoft.AspNetCore.Mvc;

namespace SysEducaConnect.UI.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult PaginaInicio()
        {
            return View();
        }

        public IActionResult Rol()
        {
            return View();
        }

        public IActionResult NuevoRol()
        {
            return View();
        }
    }
}
