/* 1. Escreva um programa com um método que verifica se um número informado
pelo usuário é positivo, negativo ou zero e imprima a resposta na tela */

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
