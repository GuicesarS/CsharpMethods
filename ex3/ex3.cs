/* 3. Elabore um programa com um método chamado VerificarPrimo que receba um
número inteiro e verifica se ele é um número primo.*/

using System;
 public class Program 
 {
   static void VerificaPrimo()
   {
      int numero=0, divisores=0;
      Console.WriteLine("Informe um numero :");
      numero=Convert.ToInt32(Console.ReadLine());

      for(int i=1;i<=numero;i++)
      {
        
         if( numero%i==0)
         {
             divisores++;
         }  
      }
          if(divisores==2)
            Console.WriteLine("PRIMO");
          else 
             Console.WriteLine("NÃO PRIMO");
   
   }
    public static void Main (string []args)
    {
        VerificaPrimo();
    }
 }
