using Microsoft.AspNetCore.Mvc;

namespace pruebas_git.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int AgregarRegistro()
        {
            int respuesta = 1;
            int otravariable = 3;
            return respuesta * otravariable;
        }
        public int ModificarRegistro()
        {
            int respuesta = 1;
            return respuesta;
        }
    }
}
