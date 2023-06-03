/*6. Faça um método que receba um array de cinco inteiros e retorne um float com a média.*/

using System;
 public class Program 
 {
   static float RetornaMedia(int[] numeros)
   {
      int soma=0;
      for(int i=0; i<5;i++)
      {
         soma+=numeros[i];
      }
      float media= (float) soma/5;
      return media;
   
   }
    public static void Main (string []args)
    {
        int[] vetor= new int[5];
        for(int i=0;i<5;i++)
        {
         Console.WriteLine("Digite o " + i + "valor");
         vetor[i]=Convert.ToInt32(Console.ReadLine());
        }
        float media=RetornaMedia(vetor);
        Console.WriteLine("A media e:" + media);
    }
 }
