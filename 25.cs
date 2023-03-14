namespace ListaDeExercicios01.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 1;
            int n;
            Console.WriteLine("Qual Fatorial você quer fazer?");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1 ; i < n + 1; i++)
            {
                soma = soma * i;
                Console.WriteLine(soma);

            }
        }
    }
}