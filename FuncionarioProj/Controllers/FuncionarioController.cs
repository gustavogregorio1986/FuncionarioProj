using Microsoft.AspNetCore.Mvc;

namespace FuncionarioProj.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
