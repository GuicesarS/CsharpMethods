/* 5. Escreva um método em C# que recebe um array de nomes e imprime a lista de nomes na tela, sem usar o comando
return.*/

using System;
public class Program
{
    static void imprimeNome(string[] nome)
    {
        for (int i=0;i<5;i++)
        {
             Console.WriteLine(nome[i]);
        }
       
    }
    
    static void Main (string[] args)
    {
        string [] nomes= {"Guilherme","Pedro","Gabriel","Klovis","Robson"};

        imprimeNome(nomes);
    }
}
