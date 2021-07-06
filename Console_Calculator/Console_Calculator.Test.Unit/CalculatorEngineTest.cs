using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Console_Calculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();
        [TestMethod]
        public void AddTwoNumbersAndReturnValidResultForNonSymbolOperation()
        {
            int number1 = 2;
            int number2 = 4;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void AddTwoNumbersAndReturnValidResultForSymbolOperation()
        {
            int number1 = 2;
            int number2 = 4;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(6, result);
        }
    }
}
