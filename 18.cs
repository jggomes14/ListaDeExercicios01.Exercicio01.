namespace ListaDeExercicios01.Exercicio18
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

            if (A>B & A>C & B>C)
            {
                Console.WriteLine("A ordem é" + A, B, C);
            }
            if (B>A & B>C & A>C)
            {
                Console.WriteLine("A ordem é" + B, A, C);
            }
            if (C>A & C>B & A>B)
            {
                Console.WriteLine("A ordem é" + C, A, B);
            }
            if (C>B & C>A & B>A)
            {
                Console.WriteLine("A ordem é" + C, B, A);
            }
            if (A>C & A>B & C>B)
            {
                Console.WriteLine("A ordem é" + A, C, B);
            }
            if (B>A & B>C & C>A)
            {
                Console.WriteLine("A ordem é" + B, C, A);
            }
        }
    }
}