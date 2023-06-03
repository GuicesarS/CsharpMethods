/* 10. Elabore um programa que contenha um método que leia uma matriz de tamanho 5x2 com valores predeterminados e
informe o maior valor da segunda coluna. */

using System;

public class Program
{
    static int EncontrarMaiorValor(int[,] matriz)
    {
        int maiorValor = matriz[0, 1];

        for (int i = 1; i < 5; i++)
        {
            int valorAtual = matriz[i, 1];
            if (valorAtual > maiorValor)
            {
                maiorValor = valorAtual;
            }
        }

        return maiorValor;
    }

    public static void Main(string[] args)
    {
        int[,] matriz = {
            { 1, 4 },
            { 2, 9 },
            { 3, 6 },
            { 4, 8 },
            { 5, 2 }
        };

        int maiorValor = EncontrarMaiorValor(matriz);

        Console.WriteLine("O maior valor da segunda coluna é: " + maiorValor);
    }
}
