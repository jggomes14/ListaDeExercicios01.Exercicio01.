using System.Security.Cryptography.X509Certificates;

namespace ListaDeExercicios01.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Insira o número para verificar se é par ou impar");
            x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("O Número é par");
            }

            else
            {
                Console.WriteLine("O Número é impar");
            }
            
        }
    }
}