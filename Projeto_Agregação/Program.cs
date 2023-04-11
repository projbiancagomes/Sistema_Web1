namespace Projeto_Agregação;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação!");

        //instanciando os objetos de cada classe
        CartaDeCredito cdc = new CartaDeCredito();
        Cliente cli = new Cliente();

        //Adicionando um nome para um cliente
        cli.Nome = "Bianca Gomes";

        //Adicionando número e validade do Cartão de Crédito
        cdc.Numero = "123456789";
        cdc.DataValidade = "07/2025";

        //Associando o clinte ao atributo de agregação em Cartão de Crédito
        cdc.Cliente = cli;
        
        //Visualizando as informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade); 
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);  
    }
}
