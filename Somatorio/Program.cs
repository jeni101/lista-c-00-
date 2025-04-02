using System;
using Somatoria.models;



class Program
{
    
    static int Somatorio(int num)
    {
        
        return num * (num + 1) / 2;
    }

    static void Main()
    {
        Console.WriteLine("digite o numero q vc deseja somar ate ele: ");
        string? numero = Console.ReadLine();  
        int num = Convert.ToInt32(numero); 

        
        Console.WriteLine($"A somatória de todos os números ate: {num} foi de:\n{Somatorio(num)} ");
    }
}

