// See https://aka.ms/new-console-template for more information
Console.WriteLine("Descubra quantos dias de vida você tem!");
string nome;
int idade;

Console.WriteLine("Insira aqui seu nome");
nome = Convert.ToString(Console.ReadLine());
Console.WriteLine("Insira aqui a sua idade");
idade = Convert.ToInt32(Console.ReadLine());

int dias = idade * 365;

Console.WriteLine(nome + ", você já viveu  " + dias + " dias");
Console.ReadKey();
