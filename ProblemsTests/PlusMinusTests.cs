using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTests;

[TestClass]
public class PlusMinusTests
{

    private int[] myArray;

    [TestInitialize]
    public void setup()
    {
        myArray = new int[] { 1, 2, -1, -2, -3, 0, 2, 4, -5, 0 };
    }


    [TestMethod]
    public void ZeroElementsPercentageInArray()
    {
        var zeroItemPercentage = PlusMinus.GetZeroPercentageElements(myArray);


        Assert.AreEqual(1, zeroItemPercentage);

    }
}