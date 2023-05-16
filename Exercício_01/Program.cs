﻿namespace Exercício_01;
class Program
{
    static void Main(string[] args)
    {
        Cao n1 = new Cao();
        Gato n2 = new Gato();
        Homem n3 = new Homem();

        n1.Fala = "Au,au";
        n2.Fala = "Miau";
        n3.Fala = "Oi";
        

        Console.WriteLine("Cão: " + n1.Fala);
        Console.WriteLine("Gato: " + n2.Fala);
        Console.WriteLine("Homem: " + n3.Fala);
        
    }
}
