namespace ListaDeExercicios01.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Conversor de Fahrenheint para Celsius!");
            Console.WriteLine("Aperte qualquer botão para continuar");
            Console.ReadKey();
            int TemperaturaFahrenheit;
          
            Console.WriteLine("Insira a temperatura em Fahrenheint");
            TemperaturaFahrenheit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A Temperatura em Celsius é de " + ((TemperaturaFahrenheit - 32) / 1.8) + "°C");

            
            


        }
    }
}