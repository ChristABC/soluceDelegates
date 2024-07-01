using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDelegates
{
    public static class MoneyDisplayer
    {
        // Méthode pour afficher en dollars
        public static void DisplayInDollars(float amount)
        {
            Console.WriteLine($"La somme d'argent en dollars est : {amount} $");
        }

        // Méthode pour afficher en euros
        public static void DisplayInEuros(float amount)
        {
            // On s'assure que l'encodage supporte les caractères spéciaux comme €
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"La somme d'argent en euros est : {amount} €");
        }
    }
}


