﻿namespace Atividade_01;
class Program
{
    static void Main(string[] args)
    {
       Gato g = new Gato();
       Cao c = new Cao();
       Homem h = new Homem();

       Console.WriteLine("O gato " + g.Emite());
       Console.WriteLine("O cao " + c.Emite());
       Console.WriteLine("O homem " + h.Emite());
    }
}