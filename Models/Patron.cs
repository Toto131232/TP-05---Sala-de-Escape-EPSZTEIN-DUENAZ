namespace saladeescape.Models;

public class Patron
{
    public List<int> Secuencia { get; set; } = new();
    public int PasoActual { get; set; } = 0;
    public bool MostrandoPatron { get; set; } = false;
    public int? BotonIluminado { get; set; } = null;
    public bool JuegoTerminado { get; set; } = false;

    private static Random _rand = new();

    public void IniciarJuego()
    {
        Secuencia.Clear();
        PasoActual = 0;
        JuegoTerminado = false;
        AgregarPaso();
    }

    public void AgregarPaso()
    {
        Secuencia.Add(_rand.Next(0, 9));
        PasoActual = 0;
    }

    public bool ValidarInput(int input)
    {
        if (input != Secuencia[PasoActual])
        {
            JuegoTerminado = true;
            return false;
        }

        PasoActual++;

        if (PasoActual >= Secuencia.Count)
        {
            AgregarPaso();
        }

        return true;
    }
}