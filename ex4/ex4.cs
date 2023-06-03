/* 4. Crie um programa com um método chamado CalcularMedia que receba o array
de números { 8.5, 9.0, 7.5, 6.0, 8.0 } e retorna a média desses valores. No método
Main, informamos o array de valores e chamamos o método CalcularMedia
passando esse array como argumento. O resultado é armazenado na variável
media e exibido no console. Sugestão para chamar o método:
static double CalcularMedia(double[] numeros) */

using System;
class Program
{
    static void Main(string[] args)
    {
        double[] numeros = { 8.5, 9.0, 7.5, 6.0, 8.0 };
        double media = CalcularMedia(numeros);
        Console.WriteLine("A média dos números é: " + media);
    }

    static double CalcularMedia(double[] numeros)
   {
        double soma = 0;
        for(int i=0;i<5;i++)
	     {
	      	soma+=numeros[i];
     	}
     	return soma/5;
   }
}

