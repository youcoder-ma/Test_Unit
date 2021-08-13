using Calculatrice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatriceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculerAdd()
        {
            var model = new SimpleCalculator();

            model.Calculate(10.4, 20.2, "+");
        }

        [TestMethod]
        public void CalculerSous()
        {
            var model = new SimpleCalculator();

            model.Calculate(1.4, 20.2, "-");
        }

        [TestMethod]
        public void CalculerDiv()
        {
            var model = new SimpleCalculator();

            model.Calculate(10.4, 20.2, "÷");
        }

        [TestMethod]
        public void CalculerMult()
        {
            var model = new SimpleCalculator();

            model.Calculate(10.4, 20.2, "×");
        }
    }
}
