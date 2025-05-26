using System.Collections.Generic;

namespace SALADEESCAPE
{
    public class GameProgress
    {
        public int SalaActual { get; set; }=1;
        public List<int> SalasCompletadas { get; set; } = new List<string>();
        public bool EstaCompletada(int sala) => SalasCompletadas.Contains(sala);
        public void SalaCompletada(int sala)
        {
            if (!SalasCompletadas.Contains(sala))
            {
                SalasCompletadas.Add(sala);
                SalaActual++;
            }
        }
    }
}