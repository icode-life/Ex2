using VS_Console_Boulangerie_Niv2;

namespace VS_Console_Boulangerie_Niv2;

public class UnitTest1
{
    [Fact]
    public void TestGetCashRegisterAmount()
    {
        //arrange
        Bakery bakery = new Bakery();
        decimal expected = bakery.GetCashRegisterAmount();

        //act
        decimal actual = bakery.GetCashRegisterAmount();

        //assert
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void TestSellBaguette()
    {
        //arrange
        Bakery bakery = new Bakery();
        decimal expected = 1.1m;
        decimal actual;

        //act
        bakery.SellBaguette();
        actual = bakery.GetCashRegisterAmount();

        //assert
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void TestSellBread()
    {
        //arrange
        Bakery bakery = new();
        decimal expected = 2.6m;
        decimal actual;

        //act
        bakery.SellBread();
        actual = bakery.GetCashRegisterAmount();

        //assert
        Assert.Equal(expected, actual);
    }
}
