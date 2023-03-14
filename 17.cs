namespace ListaDeExercicios01.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            Console.WriteLine("Insira o valor de A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor de B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor de C");
            C = Convert.ToInt32(Console.ReadLine());

            if (A + B < C)
            {
                Console.WriteLine("A soma dos valores A e B é menor que " + C);
            }
            else
            {
                Console.WriteLine("A soma dos valores A e B é maior ou igual a " + C);
            }
            Console.ReadKey();
        }
    }
}