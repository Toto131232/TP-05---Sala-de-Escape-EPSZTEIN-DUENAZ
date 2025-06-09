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
}

