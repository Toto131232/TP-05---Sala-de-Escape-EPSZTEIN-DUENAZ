using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using saladeescape.Models;

namespace saladeescape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult CasaSimpson()
    {
        return View("CasaSimpson");
    }

    public IActionResult GameOver()
    {
        return View();
    }

    public IActionResult KwikEMart()
    {
        return View("KwikEMart");
    }
    public IActionResult Krusty()
    {
        return View("krusty");
    }
    public IActionResult City()
    {
        return View("city");
    }
    public IActionResult Ganaste1()
    {
        return View("Ganaste1");
    }
    public IActionResult Ganaste2()
    {
        return View("Ganaste2");
    }
    public IActionResult Ganaste3()
    {
        return View("Ganaste3");
    }
    public IActionResult Ganaste4()
    {
        return View("Ganaste4");
    }
    public IActionResult Ganaste5()
    {
        return View("Ganaste5");
    }
    public IActionResult Moe()
    {
        return View("moe");
    }
    public IActionResult Perdiste1()
    {
        return View("Perdiste1");
    }
    public IActionResult Perdiste2()
    {
        return View("Perdiste2");
    }
    public IActionResult Perdiste3()
    {
        return View("Perdiste3");
    }
    public IActionResult Perdiste4()
    {
        return View("Perdiste4");
    }
    public IActionResult Perdiste5()
    {
        return View("Perdiste5");
    }
       public IActionResult Ganaste6()
        {
            return View();
        }

        public IActionResult Perdiste6()
        {
            return View();
        }
    public IActionResult Menu()
    {
        return View("Menu");
    }
    public IActionResult Escuela()
    {
        return View("Escuela");
    }
    public IActionResult PlantaNuclear()
    {
        return View("PlantaNuclear");
    }
    public IActionResult SalaFinal()
    {
        return View("SalaFinal");
    }
    public IActionResult ganar()
    {
        return View("ganar");
    }
  public class LisaController : Controller
    {
        private readonly string _fraseCorrecta = "LIBERTAD Y CONOCIMIENTO";

        public IActionResult Escuela()
        {
            return View("Escuela", new DiarioDeLisa());
        }

        [HttpPost]
        public IActionResult Verificar(DiarioDeLisa modelo)
        {
            if (modelo.FraseIngresada == null)
                return RedirectToAction("Perdiste");

            string ingreso = modelo.FraseIngresada.Trim().ToUpper();

            if (ingreso == _fraseCorrecta)
                return RedirectToAction("Ganaste");

            return RedirectToAction("Perdiste");
        }
    }
}