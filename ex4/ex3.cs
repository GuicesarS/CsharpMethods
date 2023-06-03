/* 4. Crie um programa com um método chamado CalcularMedia que receba o array
de números { 8.5, 9.0, 7.5, 6.0, 8.0 } e retorna a média desses valores. No método
Main, informamos o array de valores e chamamos o método CalcularMedia
passando esse array como argumento. O resultado é armazenado na variável
media e exibido no console. Sugestão para chamar o método:
static double CalcularMedia(double[] numeros) */

using System;
 public class Program 
 {
   static void testenum()
   {
      int valor=0;
      Console.WriteLine("Informe um valor :");
      valor=Convert.ToInt32(Console.ReadLine());

      if (valor<0)
         Console.WriteLine("VALOR NEGATIVO");
         else if (valor==0)
         Console.WriteLine("VALOR NULO");
         else
         Console.WriteLine("VALOR POSITIVO");
   
   }
    public static void Main (string []args)
    {
        testenum();
    }
 }
