namespace ListaDeExercicios01.Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calculo = 0;
            int N;
            Console.WriteLine("Qual Tabuada você quer fazer?");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                calculo = i * N;
                Console.WriteLine(i + " x " + N +" = " + calculo);

            }
        }
    }
}