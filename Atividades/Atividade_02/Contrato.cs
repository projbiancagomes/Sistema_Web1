namespace Atividade_02;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Tel {get;set;}

    public virtual string Base(){

        Console.WriteLine("Preencha por gentileza a ficha a baixo.");
        Console.WriteLine("");
        Console.WriteLine("DADOS PESSOAIS");
        Console.WriteLine("");

        Console.Write("Seu Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Seu E-mail: ");
        Email = Console.ReadLine();

        Console.Write("Telefone para contato: ");
        Tel = Console.ReadLine();

        string vazio = ("");
        return vazio;
    }

}