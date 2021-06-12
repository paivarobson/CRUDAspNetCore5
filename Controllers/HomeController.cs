using Microsoft.AspNetCore.Mvc;
namespace CRUDAspNetCore5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }public IActionResult Cadastrar()
        {
            return View("FormUsuario");
        }
    }
}