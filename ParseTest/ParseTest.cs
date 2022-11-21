using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParseLib;

namespace ParseTest
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string TestString = "2324+sin(343)";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), 2323.4634, 0.001);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string TestString = "cos(5,2)";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), 0.468517, 0.001);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string TestString = "cos(48)+2";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), 1.3598555, 0.001);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string TestString = "100+10";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), 110, 0.001);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string TestString = "sin(343)";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), -0.536598, 0.001);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string TestString = "0,5-0,5";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), 0, 0.001);
        }

        [TestMethod]
        public void TestMethod7()
        {
            string TestString = "cos(1)";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), 0.54030, 0.001);
        }

        [TestMethod]
        public void TestMethod8()
        {
            string TestString = "sin(cos(-342))";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), -0.787942, 0.001);
        }

        [TestMethod]
        public void TestMethod9()
        {
            string TestString = "cos(4123)+10)";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), 10.33382, 0.001);
        }

        [TestMethod]
        public void TestMethod10()
        {
            string TestString = "4-15";
            Parse parse = new Parse(TestString);
            Assert.AreEqual(parse.CalculateExpression(), -11, 0.001);
        }
    }
}
