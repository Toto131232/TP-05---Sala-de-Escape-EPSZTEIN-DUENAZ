using System.Collections.Generic;

namespace SALADEESCAPE
{
    public class AdivinarPersonaje
    {
        public string NombreAAdvinar {get; private set;}
        public bool Adivino{get; private set;}=false;
        public void VerificarNombre(string nombre)
        {
            if(NombreAAdvinar==nombre)
            {
                Adivino=true;
            }

        }
    }
        
}

