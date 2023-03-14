namespace ListaDeExercicios01.Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de IMC");

            int peso;
            decimal altura;
            
            Console.WriteLine("Insira o peso");
            peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a altura");
            altura = Convert.ToDecimal(Console.ReadLine());

            decimal IMC = (peso / (altura * altura));

            if (IMC < 18.5M)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            if (IMC > 18.5M & IMC < 25.0M)
            {
                Console.WriteLine("Peso Normal");
            }
            if (IMC > 25.0M & IMC < 30.0M)
            {
                Console.WriteLine("Acima do Peso");
            }
            if (IMC > 30.0M)
            {
                Console.WriteLine("Obeso");
            }
            Console.ReadKey();

        }
    }
}