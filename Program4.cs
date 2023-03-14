namespace ListaDeExercicios01.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Consumo de Combustivel por Km");

            int KmInicial;
            int KmFinal;
            int ConsumoDeCombustivel;
            

            Console.WriteLine("Insira a Quilometragem Inicial do Veiculo");
            KmInicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a Quilometragem Final do Veiculo");
            KmFinal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o Consumo de Combustivel ao final do percurso");
            ConsumoDeCombustivel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O Combustivel consumido por Km percorrido foi de " + (KmFinal - KmInicial) / (ConsumoDeCombustivel));



        }
    }
}