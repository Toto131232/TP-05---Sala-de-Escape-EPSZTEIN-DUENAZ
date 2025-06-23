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
        return View("Index");
    }
    public IActionResult CasaSimpson()
    {
        return View("CasaSimpson");
    }
    private static Patron _game = new();

    private static Patron _juego = new();

    public IActionResult PlantaNuclear()
    {
        if (_juego.JuegoTerminado)
            return RedirectToAction("GameOver");

        ViewBag.BotonIluminado = _juego.BotonIluminado;
        return View(_juego);
    }

    public IActionResult Iniciar()
    {
        _juego.IniciarJuego();
        return RedirectToAction("MostrarPatron");
    }

    public async Task<IActionResult> MostrarPatron()
    {
        _juego.MostrandoPatron = true;

        foreach (int paso in _juego.Secuencia)
        {
            _juego.BotonIluminado = paso;
            await Task.Delay(600);
            _juego.BotonIluminado = null;
            await Task.Delay(200);
        }

        _juego.MostrandoPatron = false;
        return RedirectToAction("PlantaNuclear");
    }
    public IActionResult InputUsuario(int botonId)
    {
        if (!_juego.ValidarInput(botonId))
            return RedirectToAction("GameOver");

        return RedirectToAction("MostrarPatron");
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

}