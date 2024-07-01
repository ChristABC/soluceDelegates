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
            Console.WriteLine($"{amount:C2} $");
        }

        // Méthode pour afficher en euros
        public static void DisplayInEuros(float amount)
        {
            Console.WriteLine($"{amount:C2} €");
        }
    }
}


