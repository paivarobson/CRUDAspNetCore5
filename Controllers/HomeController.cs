using Microsoft.AspNetCore.Mvc;
using CRUDAspNetCore5.Models;
using System.Linq;

namespace CRUDAspNetCore5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Cadastrar(int? id)
        {
            if (id.HasValue && Usuario.Listagem.Any(u => u.Id == id))
            {
                var usuario = Usuario.Listagem.Single(u => u.Id == id);
                return View(usuario);
            }

            return View();
        }

        public IActionResult Usuarios()
        {
            return View();
        }
    }
}