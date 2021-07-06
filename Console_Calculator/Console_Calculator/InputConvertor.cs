using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    public class InputConvertor
    {
        public double ConvertInputToNumber(string argTextInput)
        {
            double convertedNumber;
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a Numeric Value");
            return convertedNumber;
        }
    }
}
