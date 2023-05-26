namespace Atividade_02;
class Juridica: Contrato
{
    public string? cnpj {get;set;}
    public string? IE {get;set;}
    public string? NE {get;set;}

    public override string Base(){

        base.Base();

        Console.WriteLine("");
        Console.WriteLine("DADOS DA EMPRESA");
        Console.WriteLine("");

        Console.Write("CNPJ: ");
        cnpj = Console.ReadLine();

        Console.Write("IE: ");
        IE = Console.ReadLine();

        Console.Write("NE: ");
        NE = Console.ReadLine();
        Console.WriteLine("");

        string vazio = ("Obrigada!!");
        return vazio ;
    }

}