/* 2. Crie um programa que contenha um método que leia 3 números inteiros,
calcule a sua média e retorne o resultado para o usuário */

using System;
 public class Program 
 {
   static void Media()
   {
      double valor=0,media=0, total=0;
      for (int i=0;i<3;i++)
      {
         Console.WriteLine("Informe um valor :");
         valor=Convert.ToDouble(Console.ReadLine());

         total+=valor;
      }
         Console.WriteLine("VALOR TOTAL:" +total);
         media=total/3;
         Console.WriteLine("VALOR DA MEDIA:" +media);
   
   }
    public static void Main (string []args)
    {
        Media();
    }
 }
