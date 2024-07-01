using System;
using projDelegates;

namespace ShowMoney
{
    class Program
    {
        // Définition de la déléguée ShowMoney
        delegate void ShowMoney(float amount);

        static void Main(string[] args)
        {
            float amount = 12.15f ;// On ajoute le 'f' pour dire qu'on a un nombre flottant

            // Instanciation de la déléguée avec la méthode DisplayInDollars de MoneyDisplayer
            ShowMoney showMoney = MoneyDisplayer.DisplayInDollars;
            showMoney(amount);

            // Réaffectation de la déléguée avec la méthode DisplayInEuros de MoneyDisplayer
            showMoney = MoneyDisplayer.DisplayInEuros;
            showMoney(amount);
        }
    }
}