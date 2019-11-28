using System;
using System.Collections.Generic;
using System.Text;

namespace POOAdap
{
    public static class OperationContext
    {
        public IStrategy GetStrategy(int Operacao) 
        {
            switch(Operacao)
            {
                case 0:
                    return new Adicao();
                case 1:
                    return new Subtracao();
                case 2:
                    return new Multiplicacao();
                case 3:
                    return new Divisao();
                default:
                    Console.WriteLine("Ocorreu uma falha ao definir a operação desejada");
                    break;
            }
        }
    }
}
