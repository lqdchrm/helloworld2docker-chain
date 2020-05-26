using AddTwoNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddTwoNumbersTests
{
    [TestClass]
    public class AddingTest
    {
        [TestMethod]
        public void TestAddingTwoNumbers()
        {
            var fixture = new { a = 5, b = 4, expected = 9 };

            var actual = Calc.AddNumbers(fixture.a, fixture.b);
            Assert.AreEqual(fixture.expected, actual);
        }
    }
}
