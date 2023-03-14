using static System.Net.Mime.MediaTypeNames;

namespace ListaDeExercicios01.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcule o volume de uma lata");

            int raio;
            int altura;
            Console.WriteLine("Insira o raio da lata");
            raio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a altura da lata");
            altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O volume da lata é de " + ((raio * raio) * 3.14) * (altura));
            
        }
    }
}