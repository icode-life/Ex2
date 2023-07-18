using System;

namespace VS_Console_Boulangerie_Niv2
{
    public class Bakery
    {
        private float CashRegisterAmount { get; set; } = 0;

        public void SellBaguette()
        {
            Console.WriteLine("Vente d'une baguette enregistrée\n\n");
            CashRegisterAmount += 1.1F;
        }

        public void SellBread()
        {
            Console.WriteLine("Vente d'un pain enregistrée\n\n");
            CashRegisterAmount += 2.6F;
        }

        public float GetCashRegisterAmount()
        {
            return CashRegisterAmount;
        }
    }
}
