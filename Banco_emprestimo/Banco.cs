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
    string result1 = " Valor da prestação do seu empréstimo: R$" +emprestimo;
    return result1;
   }

   public string juros(double n1,double n3){
   this.valor = n1;
   this.taxa = n3;
   double juros = this.valor * this.taxa;
   string result2 = " Valor do juros do seu empréstimo: " +juros+"%";
   return result2;
   }

   public string prestacao (double n3, double n4){
    this.taxa = n3;
    this.mes = n4;
    double prestacao = this.taxa + this.mes;
    string result3 = " Valor do juros com o valor da prestação de seu empréstimo: R$"+prestacao;
    return result3;
   }
   public string ano (double n2, double n4){
      this.prazo = n2;
      this.mes = n4;
      double ano = this.prazo * this.mes;
      string result4 = " Valor total a pagar: R$"+ano;
      return result4;
   }
   
   public void imprime(string texto){
    Console.WriteLine(texto);
   }
}
