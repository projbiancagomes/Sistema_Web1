namespace Atividade_03;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Tel {get;set;}
    public int meses {get;set;}
    public decimal valor {get;set;}

    public decimal Prestacao {get;set;}


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

    public virtual decimal CalcularPrestacao(){

        Console.WriteLine("");
        Console.WriteLine("DADOS PRESTACAO");
        Console.WriteLine("");
        
        Console.Write("Valor: ");
        valor = int.Parse(Console.ReadLine());

        Console.Write("Meses: ");
        meses = int.Parse(Console.ReadLine());

       decimal Prestacao = valor/meses;
       return Prestacao;
    }

}