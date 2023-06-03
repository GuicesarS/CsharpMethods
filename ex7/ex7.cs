/* 7. Faça um método que receba um valor float em metros e retorne seu valor em centímetros.*/

using System;
 public class Program 
 {
   static float ConveteCm(float metros)
   {
        float centimetros = metros * 100;
        return centimetros;
   
   }
    public static void Main (string []args)
    {
        float metros=0,centimetros=0;
        Console.WriteLine("Digite o valor (Metros) :");
        metros=float.Parse(Console.ReadLine());
        centimetros=ConveteCm(metros);

        Console.WriteLine("O valor convetido para centimetros :" + centimetros);

    }
 }
