namespace ListaDeExercicios01.Exercicio21
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

            if (A == B)
            {
                C = A + B;
                Console.WriteLine(C);
            }
            else
            {
                C = A * B;
                Console.WriteLine(C);

            }
            Console.ReadKey();
        }
    }
}