using Microsoft.AspNetCore.Mvc;


namespace CadastroEstudantes.Controllers
{
    public class EstudanteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
