namespace Atividade_02;
class Fisica: Contrato
{
    public string? cpf {get;set;}
    public string? idade {get;set;}

    public override string Base(){

        base.Base();

        Console.Write("CPF: ");
        cpf = Console.ReadLine();

        Console.Write("IDADE: ");
        idade = Console.ReadLine();
        Console.Write("");

        string vazio = ("Obrigada!!");
        return vazio ;
        
    }

}