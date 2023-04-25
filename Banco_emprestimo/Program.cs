namespace Banco_emprestimo;
class Program
{
    static void Main(string[] args)
    {
        Banco b = new Banco();

        b.imprime(b.emprestimo(1000,12));
        b.imprime(b.juros(1000,0.06));
        b.imprime(b.prestacao(60,83));
         b.imprime(b.ano(12,143.33));
    }
}
