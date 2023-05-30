namespace Exemplo;
class Program
{
    static void Main(string[] args)
    {
       //Instância de cada classe filha
       Estadual prodEstadual = new Estadual();
       Nacional prodNacional = new Nacional();
       Importado prodImport = new Importado();

        //Instanciando valores para os produtos Etadual
       Console.WriteLine("Digite a descrição do Prood Estadual");
       prodEstadual.Descricao = Console.ReadLine();
       Console.WriteLine("Digite o valor do Prood Estadual");
       prodEstadual.Valor = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite o valor do imposto do Prood Estadual");
       prodEstadual.Imposto =  Convert.ToDouble(Console.ReadLine());
       
       //Instanciando valores para os produtos Nacional
       Console.WriteLine("Digite a Descrição Prood Nacional");
       prodNacional.Descricao = Console.ReadLine();
       Console.WriteLine("Digite o Valor Prood Nacional");
       prodNacional.Valor = Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite o valor do Imposto Prood Nacional");
       prodNacional.Imposto =  Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Digite o valor da Taxa Prood Nacional");
       prodNacional.Taxa =  Convert.ToDouble(Console.ReadLine());

       Console.WriteLine("Valor do produto calculado com imposto");
       
       
    }
}
