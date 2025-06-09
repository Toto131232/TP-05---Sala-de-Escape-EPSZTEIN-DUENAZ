using System.Collections.Generic;

namespace SALADEESCAPE
{
    public class AdivinarPersonaje
    {
        public string[] NombreAAdvinar {get; private set;}=GenerarPersonajes();
        public string foto{get; private set;}
        public string fotoPixelArt{get; private set;}
        
        public static string[] GenerarPersonajes()
        {
           string[] personajes=new string[]
           {"Nelson", "Bob Patiño", "Lisa", "Apu","Ayudante de Santa"};
           return personajes;
        }
        public bool VerificarNombre(string nombre, int i)
        {
            bool Adivino=false;
            if(nombre==NombreAAdvinar[i])
            {
                Adivino=true;
            }
            return Adivino;
        }
    }
        
}

