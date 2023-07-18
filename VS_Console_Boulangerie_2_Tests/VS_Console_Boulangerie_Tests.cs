using VS_Console_Boulangerie_Niv2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VS_Console_Boulangerie_Niv2;

public class UnitTest1
{
    [Fact]

    public void TestGetCashRegisterAmount()
    {
        //arrange
        Bakery bakery = new Bakery();
        bakery.GetCashRegisterAmount = 2.3F;
        float expected = bakery.CashRegisterAmount;

        //act
        float actual = bakery.GetCashRegisterAmount();

        //assert
        Assert.AreEqual(expected, actual, 0.01);
    }
        
    public void TestSellBaguette()
    {
        //arrange
        Bakery bakery = new Bakery();
        float expected = 1.1F;

        //act
        bakery.SellBaguette();

        //assert
        float actual = bakery.GetCashRegisterAmount();
    }
}
