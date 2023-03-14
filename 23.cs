// See https://aka.ms/new-console-template for more information
int soma = 0;
for (int i = 1; i <500; i++)
{

    if ((i % 2) != 0)
    {
        if (i % 3 == 0)
        {
            soma = soma + i;
            Console.WriteLine(soma);
        }
        

    }
}


