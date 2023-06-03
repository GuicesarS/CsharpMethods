/* 9. Elabore um programa que leia uma matriz de tamanho 3x3 com valores predeterminados. Crie o método
CalcularSomaMatriz para receber a matriz como parâmetro e calcular a soma de todos os seus elementos Essa soma é
retornada pelo método para o programa principal para ser impresso na tela. */

using System;

public class Program
{
    static int CalcularSomaMatriz(int[,] matriz)
    {
        int soma = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                soma += matriz[i, j];
            }
        }

        return soma;
    }

    public static void Main(string[] args)
    {
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int soma = CalcularSomaMatriz(matriz);

        Console.WriteLine("A soma dos elementos da matriz é: " + soma);
    }
}

