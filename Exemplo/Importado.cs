namespace Exemplo;
class Importado:Produto
{
    public double Taxa {get;set;}
    public double TaxaImport {get;set;}

    public override double calculaValor()
    {
        double tx =(1+(this.Taxa/100));
        double tximp = this.Valor*(this.TaxaImport/100);
        return base.calculaValor()+ tx + tximp;
    }
}
