﻿namespace Atividade_02;
class Program
{
    static void Main(string[] args)
    {
        Fisica fis = new Fisica();
        Juridica jur = new Juridica();
    
        Console.WriteLine("Você é uma pessoa física ou juridica?");
        string? metrica = Console.ReadLine();

       switch (metrica)
        {
            case "física":
                Console.WriteLine(fis.Base());
                break;

            case "juridica":
                Console.WriteLine(jur.Base());
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }
}