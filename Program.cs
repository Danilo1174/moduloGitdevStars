using System;

namespace modulo_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Atividade:
             * Crie um programa que receba dois valores e calcule a soma desses valores.
             * Ao final exiba o resultado no console.
             * 
             */
            #region Base
            Console.WriteLine("Digite 1 para iniciar o programa ou digite 0 para sair");
            int opcao = int.Parse(Console.ReadLine());
            while (opcao != 0)
            {
                int a, b;
                Console.WriteLine("informa o valor dos numeros a serem somados");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int resultado = Soma(a + b);
                Console.WriteLine("a soma dos  valores e igual a " + resultado);
                Console.WriteLine("se deseja repetir digite 1 se nao digite 0");
                opcao = int.Parse(Console.ReadLine());

            }
            #endregion

        }
        static int Soma(int a, int b)
        {
            return a + b;
        }
        static int Subtracao(int a, int b)
        {
        return a - b;

        }
            

    }
}
