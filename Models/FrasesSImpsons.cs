using System.Collections.Generic;

namespace SALADEESCAPE
{
    public class FrasesSimpsons
    {
        public static string[] FrasesFamosas{get; set;}=GenerarFrases();

        public static string[] GenerarFrases()
        {
            string[] Frases=new string[]
           {"Que elegancia la de Francia", "¿Que te paso viejo? antes eras chevere"};
           return Frases;
        }
        public static bool VerificarFrase(string frase, int i)
        {
            bool Adivino=false;
            if(frase==FrasesFamosas[i])
            {
                Adivino=true;
            }
            return Adivino;
        }
    }
        
}