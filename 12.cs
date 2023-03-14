namespace ListaDeExercicios01.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dimensões de Área de um Retângulo");

            int b;
            int altura;

            Console.WriteLine("Qual a base do terreno?");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a Altura do terreno?");
            altura = Convert.ToInt32(Console.ReadLine());

            int area = b * altura;

            Console.WriteLine("A área do terreno é " + area);

        }
    }
}