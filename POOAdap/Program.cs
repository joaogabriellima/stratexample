using System;

namespace POOAdap
{
    public class Program
    {
        public static int Operacao { get; set; }
        public static double FirstNumber { get; set; }
        public static double SecondNumber { get; set; }
        public static double Result { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, selecione a operação desejada");
            Console.WriteLine("0 - Adiçao, 1 - Subtração, 2 - Multiplicação, 3 - Divisão");
            Operacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Agora digite os números a serem utilizados");
            FirstNumber = Convert.ToDouble(Console.ReadLine());
            SecondNumber = Convert.ToDouble(Console.ReadLine());

            OperationContext _strategy;

            switch(Operacao)
            {
                case 0:
                    _strategy = new OperationContext(new Adicao());
                    Result = _strategy.ExecutaStrategy(FirstNumber, SecondNumber);
                    Console.WriteLine($"Sua soma deu: {Result}");
                    break;
                case 1:
                    _strategy = new OperationContext(new Subtracao());
                    Result = _strategy.ExecutaStrategy(FirstNumber, SecondNumber);
                    Console.WriteLine($"Sua subtracao deu: {Result}");
                    break;
                case 2:
                    _strategy = new OperationContext(new Multiplicacao());
                    Result = _strategy.ExecutaStrategy(FirstNumber, SecondNumber);
                    Console.WriteLine($"Sua multiplicação deu: {Result}");
                    break;
                case 3:
                    _strategy = new OperationContext(new Divisao());
                    Result = _strategy.ExecutaStrategy(FirstNumber, SecondNumber);
                    Console.WriteLine($"Sua divisão deu: {Result}");
                    break;
                default:
                    Console.WriteLine("Ocorreu uma falha ao definir a operação desejada");
                    break;
            }
        }
    }
}
