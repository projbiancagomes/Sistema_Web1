namespace Exemplo;
class Produto
{
    public string? Descricao {get;set;}
    public double valor {get;set;}
    public double imposto{get;set;}
    public double calculaValor(double valor){
        return valor*1.1;
    }
}
