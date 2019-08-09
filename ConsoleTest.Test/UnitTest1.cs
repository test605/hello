using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleTest;
namespace ConsoleTest.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           int answer = Program.add(1,2);
            Assert.AreEqual(3, answer);
            
        }
    }
}
