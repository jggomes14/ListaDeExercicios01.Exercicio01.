namespace ListaDeExercicios01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o volume da caixa retangular");
            decimal Comprimento;
            decimal Largura;
            decimal Altura;
            
            Console.ReadKey();
            Console.WriteLine("Insira o Comprimento");
            Comprimento = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o Largura");
            Largura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o Altura");
            Altura = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O Volume da Caixa Retangular é " + (Comprimento * Largura * Altura) + "L" );



        }
    }
}