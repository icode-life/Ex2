using System;

namespace VS_Console_Boulangerie_Niv2
{
    public class Bakery
    {
        private decimal CashRegisterAmount { get; set; } = 0;

        public void SellBaguette()
        {
            CashRegisterAmount += 1.1m;
        }

        public void SellBread()
        {
            CashRegisterAmount += 2.6m;
        }

        public decimal GetCashRegisterAmount()
        {
            return CashRegisterAmount;
        }
    }
}
