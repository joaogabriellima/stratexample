using System;
using System.Collections.Generic;
using System.Text;

namespace POOAdap
{
    public class Subtracao : IStrategy
    {
        public double Calcular(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
