namespace ListaDeExercicios01.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculo de Salário com Imposto");
            decimal SalarioBase;
            decimal Aumento = 0.15M;
            decimal Imposto = 0.08M;


            Console.WriteLine("Insira o seu salário base");
            SalarioBase = Convert.ToDecimal(Console.ReadLine());
          
            decimal salarioNovo = ((SalarioBase * Aumento) + SalarioBase);

           
            Console.Write("O seu salário antigo era de R$" + SalarioBase + ", seu salário com aumento é de R$" + salarioNovo + " e seu salario descontado de impostos é de R$ " + ((salarioNovo - (salarioNovo * Imposto))));

            Console.ReadKey();

        }
    }
}