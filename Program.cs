namespace ListaDeExercicios01.Exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calculo = 0;
            int calculo1 = 0;
            int calculo2 = 0;
            int calculo3 = 0;
            int calculo4 = 0;
            int calculo5 = 0;
            int calculo6 = 0;
            int calculo7 = 0;
            int calculo8 = 0;
            int calculo9 = 0;


            
            for (int i = 1; i < 11; i++)
            {
                calculo = i * 1;
                calculo1 = i * 2;
                calculo2 = i * 3;
                calculo3 = i * 4;
                calculo4 = i * 5;
                calculo5 = i * 6;
                calculo6 = i * 7;
                calculo7 = i * 8;
                calculo8 = i * 9;
                calculo9 = i * 10;



                Console.WriteLine(i + " x " + 1 + " = " + calculo);
                Console.WriteLine(1 + " x " + i + " = " + calculo);
                Console.WriteLine(i + " x " + 2 + " = " + calculo1);
                Console.WriteLine(2 + " x " + i + " = " + calculo1);
                Console.WriteLine(i + " x " + 3 + " = " + calculo2);
                Console.WriteLine(3 + " x " + i + " = " + calculo2);
                Console.WriteLine(i + " x " + 4 + " = " + calculo3);
                Console.WriteLine(4 + " x " + i + " = " + calculo3);
                Console.WriteLine(i + " x " + 5 + " = " + calculo4);
                Console.WriteLine(5 + " x " + i + " = " + calculo4);
                Console.WriteLine(i + " x " + 6 + " = " + calculo5);
                Console.WriteLine(6 + " x " + i + " = " + calculo5);
                Console.WriteLine(i + " x " + 7 + " = " + calculo6);
                Console.WriteLine(7 + " x " + i + " = " + calculo6);
                Console.WriteLine(i + " x " + 8 + " = " + calculo7);
                Console.WriteLine(8 + " x " + i + " = " + calculo7);
                Console.WriteLine(i + " x " + 9 + " = " + calculo8);
                Console.WriteLine(9 + " x " + i + " = " + calculo8);
                Console.WriteLine(i + " x " + 10 + " = " + calculo9);
                Console.WriteLine(10 + " x " + i + " = " + calculo9);

            }
        }
    }
}