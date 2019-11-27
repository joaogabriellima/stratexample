using System;
using System.Collections.Generic;
using System.Text;

namespace POOAdap
{
    public class Adicao : IStrategy
    {
        public double Calcular(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        } 
    }
}
