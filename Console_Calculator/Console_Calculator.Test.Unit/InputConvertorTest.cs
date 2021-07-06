using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Console_Calculator.Test.Unit
{
    [TestClass]
    public class InputConvertorTest
    {
        private readonly InputConvertor _inputConvertor = new InputConvertor();
        [TestMethod]
        public void ConvertValidStringToDouble()
        {
            string inputNumber = "4";
            double convertedNumber = _inputConvertor.ConvertInputToNumber(inputNumber);
            Assert.AreEqual(4, convertedNumber);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertValidStringToDoubleFail()
        {
            string inputNumber = "e4";
            double convertedNumber = _inputConvertor.ConvertInputToNumber(inputNumber);
            Assert.AreEqual(4, convertedNumber);
        }
    }
}
