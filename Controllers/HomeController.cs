using Microsoft.AspNetCore.Mvc;

namespace PaisesWeb.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaises = Info.ListarPaises();
        return View();
    }
     public IActionResult DetallePais(string nombrePais)
    {
        ViewBag.Pais = Info.DetallePais(nombrePais);
        return View();
    }
}
