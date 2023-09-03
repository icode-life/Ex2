using System;

namespace VS_Console_Boulangerie_Niv2
{
    public class Bakery
    {
        private float CashRegisterAmount { get; set; } = 0;

        public void SellBaguette()
        {
            CashRegisterAmount += 1.1F;
        }

        public void SellBread()
        {
            CashRegisterAmount += 2.6F;
        }

        public float GetCashRegisterAmount()
        {
            return CashRegisterAmount;
        }
    }
}
