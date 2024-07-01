using System;
using projDelegates;

namespace ShowMoney
{
    class Program
    {
        // Définition de la delegate ShowMoney
        delegate void ShowMoney(float amount);

        static void Main(string[] args)
        {
            float amount = 12.15f ;// On ajoute le 'f' pour dire qu'on a un nombre flottant

            // Instanciation de la delegate avec la méthode DisplayInDollars de MoneyDisplayer
            ShowMoney showMoney = MoneyDisplayer.SommeEnDollars;
            showMoney(amount);

            // Réaffectation de la delegate avec la méthode DisplayInEuros de MoneyDisplayer
            showMoney = MoneyDisplayer.SommeEnEuros;
            showMoney(amount);
        }
    }
}