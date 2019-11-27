using System;
using System.Collections.Generic;
using System.Text;

namespace POOAdap
{
    public class OperationContext
    {
        private IStrategy _strategy;

        public OperationContext(IStrategy strategy)
        {
            this._strategy = strategy;
        } 

        public double ExecutaStrategy(double firstNumber, double secondNumber)
        {
            return this._strategy.Calcular(firstNumber, secondNumber);
        }

    }
}
