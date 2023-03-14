namespace ListaDeExercicios01.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Salário com Comissão de Venda");
            decimal SalarioBase;
            decimal ValorDasVendas;
            decimal Comissao;

            Console.WriteLine("Insira o seu salário base");
            SalarioBase = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Insira o total de vendas do mês");
            ValorDasVendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual a porcentagem de comissão?");
            Comissao = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("O seu salário esse mês será R$ "+((SalarioBase) + (ValorDasVendas) * (Comissao / 100)));
            Console.ReadKey();

        }
    }
}