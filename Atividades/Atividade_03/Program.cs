﻿namespace Atividade_03;
class Program
{
    static void Main(string[] args)
    {
        Fisica fis = new Fisica();
        Juridica jur = new Juridica();
    
        Console.WriteLine("Você é uma pessoa fisica ou juridica?");
        string metrica = Console.ReadLine();

       switch (metrica)
        {
            case "fisica":
                Console.WriteLine(fis.Base());
                Console.WriteLine("Valor da parcela: " + fis.CalcularPrestacao());
                break;

            case "juridica":
                Console.WriteLine(jur.Base());
                Console.WriteLine("Valor da parcela: " + jur.CalcularPrestacao());
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }
}