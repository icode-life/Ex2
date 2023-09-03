using VS_Console_Boulangerie_Niv2;

namespace VS_Console_Boulangerie_Niv2;

public class UnitTest1
{
    [Fact]
    public void TestGetCashRegisterAmount()
    {
        //arrange
        Bakery bakery = new Bakery();
        float expected = bakery.GetCashRegisterAmount();

        //act
        float actual = bakery.GetCashRegisterAmount();

        //assert
        Assert.Equal(expected, actual, 0.01);
    }


    [Fact]
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


    [Fact]
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
