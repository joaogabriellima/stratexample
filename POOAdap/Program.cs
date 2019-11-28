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

            var result = OperationContext.GetStrategy(Operacao).Calcular(FirstNumber, SecondNumber);
            Console.WriteLine("asudhaushd " + result);
        }
    }
}
