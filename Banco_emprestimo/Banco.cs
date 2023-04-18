namespace Banco_emprestimo;
class Banco
{
   public double valor {get;set;}
   public double prazo {get;set;}
   public double taxa {get;set;}
   public double mes {get;set;}
   public double total {get;set;}


   public string emprestimo(double n1, double n2){
    this.valor = n1;
    this.prazo = n2;
    double emprestimo = this.valor / this.prazo;
    string result1 = "A prestação de "+this.valor+ " com "+this.prazo+" é: "+emprestimo;
    return result1;
   }

   public string juros(double n1,double n3){
   this.valor = n1;
   this.taxa = n3;
   double juros = this.valor * this.taxa;
   string result2 = "O valor "+this.valor+ " do juros "+this.taxa+" é: "+juros;
   return result2;
   }

   public string prestacao (double n3, double n4){
    this.taxa = n3;
    this.mes = n4;
    double prestacao = this.taxa + this.mes;
    string result3 = "O valor do juros "+this.taxa+ " com o valor do emprestimo " +this.mes+"é: "+prestacao;
    return result3;
   }

   public void imprime(string texto){
    Console.WriteLine(texto);
   }
}
