/* 8. Crie um programa que tenha um método que calcule a área de um triângulo, onde o usuário informa a base e a altura. O
resultado será armazenado em um array, juntamente com a base e a altura informadas.
Exemplo: Base = 5, Altura = 10. Area = (Base*Altura)/2. Array: {12.5, 5, 10} */

using System;

public class Program
{
    static double[] CalcularAreaTriangulo(double baseTriangulo, double altura)
    {
        double area = (baseTriangulo * altura) / 2;
        double[] resultado = { area, baseTriangulo, altura };
        return resultado;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a base do triângulo:");
        double baseTriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura do triângulo:");
        double altura = double.Parse(Console.ReadLine());

        double[] resultado = CalcularAreaTriangulo(baseTriangulo, altura);

        Console.WriteLine("Área do triângulo: " + resultado[0]);
        Console.WriteLine("Base informada: " + resultado[1]);
        Console.WriteLine("Altura informada: " + resultado[2]);
    }
}
