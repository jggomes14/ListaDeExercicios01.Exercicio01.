namespace ListaDeExercicios01.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora da HotPão");

            int pao;
            int broa;

            Console.WriteLine("Insira a quantidade de pães vendidos");
            pao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de broas vendidas");
            broa = Convert.ToInt32(Console.ReadLine());

            int valorDoPao = pao * (12 / 100);
            int valorDaBroa = broa * (150 / 100);

            int GanhoTotal = valorDaBroa + valorDoPao;

            int Poupanca = GanhoTotal * (10 / 100);

            Console.WriteLine("O Ganho total foi de R$ " + GanhoTotal + ". E a quantidade que deve ir pra poupança é de R$ " + Poupanca);

        }
    }
}