using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_7;
namespace Lab7Testing
{
    [TestClass]
    public class Lab7Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            int totalgoals = 1;
            Soccer sc = new Soccer(totalgoals);
            int expectedResult = 5;
            int actualResult = sc.Addgoal(4);
            Assert.AreEqual(expectedResult, actualResult, "The answer is correct");
        }
    }
}
