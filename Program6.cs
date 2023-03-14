namespace ListaDeExercicios01.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Temperatura Celsius para Fahrenheint");
            int TemperaturaCelsius;
            Console.WriteLine("Insira a temperatura em Celsius");
            TemperaturaCelsius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A Temperatura em Fahrenheint é " + (TemperaturaCelsius * 1.8) + 32 + "F");

        }
    }
}