﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo de Média Harmonica");
double nota1;
double nota2;
double nota3;


Console.WriteLine("Insira a nota 1");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira a nota 2");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira a nota 3");
nota3 = Convert.ToDouble(Console.ReadLine());

double notaHarmonica = 3 / ((1 / nota1) + (1 / nota2) + (1 / nota3));

Console.WriteLine("A Média Harmônica é" + notaHarmonica);