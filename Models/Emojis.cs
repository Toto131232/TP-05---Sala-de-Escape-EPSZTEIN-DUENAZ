using System.Collections.Generic;

namespace SALADEESCAPE
{
    public class Emojis
    {
        public static string[] Personajes{get; set;}=GenerarPersonajes();
        public string[] EmojiPersonajes{get;set;}
        public string[] Fotos{get;set;}

        public static string[] GenerarPersonajes()
        {
            string[] personajes=new string[]
           {"Krusty", "Berns","Bart","Milhouse","Maggie","Flanders"};
           return personajes;
        }
         public static bool VerificarPersonaje(string personaje, int i)
        {
            bool Adivino=false;
            if(personaje==Personajes[i])
            {
                Adivino=true;
            }
            return Adivino;
        }


    }
}