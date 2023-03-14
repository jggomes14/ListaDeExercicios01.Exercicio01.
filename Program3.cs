namespace ListaDeExercicios01.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos Calcular o Volume de um Cilindro");
            Console.ReadKey();
            int altura;
            int raio;

            Console.WriteLine("Insira a altura do cilindro");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o raio do cilindro");
            raio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O Volume é igual a " + (3.14 * altura) * (raio * raio));
            
        }
    }
}