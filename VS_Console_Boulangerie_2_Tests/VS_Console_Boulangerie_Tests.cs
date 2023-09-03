using VS_Console_Boulangerie_Niv2;

namespace VS_Console_Boulangerie_Niv2;

public class UnitTest1
{
    [Fact]

    public void TestGetCashRegisterAmount()
    {
        //arrange
        Bakery bakery = new Bakery();
        //error setting the value 
        bakery.CashRegisterAmount = 2.3F;
        //error getting the value
        float expected = bakery.CashRegisterAmount;

        //act
        float actual = bakery.GetCashRegisterAmount();

        //assert
        Assert.Equal(expected, actual, 0.01);
    }
        
    public void TestSellBaguette()
    {
        //arrange
        Bakery bakery = new Bakery();
        float expected = 1.1F;
        float actual;

        //act
        bakery.SellBaguette();
        actual = bakery.GetCashRegisterAmount();

        //assert
        Assert.Equal(expected, actual, 0.01);
    }

    public void TestSellBread()
    {
        //arrange
        Bakery bakery = new();
        float expected = 2.6F;
        float actual;

        //act
        bakery.SellBread();
        actual = (float)bakery.GetCashRegisterAmount();

        //assert
        Assert.Equal(expected, actual, 0.01);
    }
}
