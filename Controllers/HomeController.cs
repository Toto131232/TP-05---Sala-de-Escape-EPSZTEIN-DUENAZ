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
    public IActionResult Moe()
    {
        return View("moe");
    }
private static readonly List<string> palabrasClave = new()
        {
            "homero", "duff", "barney", "moe", "squishee",
            "donuts", "flanders", "lisa", "cerveza", "springfield"
        };

        [HttpGet]
        public IActionResult Index(int ronda = 0)
        {
            if (ronda < 0 || ronda >= palabrasClave.Count)
                return RedirectToAction("Perdiste");

            ViewBag.Ronda = ronda;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string FraseIngresada, int ronda)
        {
            if (ronda < 0 || ronda >= palabrasClave.Count)
                return RedirectToAction("Perdiste");

            var correcta = palabrasClave[ronda].ToLower();

            if (FraseIngresada?.Trim().ToLower() == correcta)
            {
                ronda++;
                if (ronda >= palabrasClave.Count)
                    return RedirectToAction("Ganaste");

                return RedirectToAction("Index", new { ronda });
            }

            return RedirectToAction("Perdiste");
        }

        public IActionResult Ganaste() => View();
        public IActionResult Perdiste() => View();
}



