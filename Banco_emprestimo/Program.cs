namespace Banco_emprestimo;
class Program
{
    static void Main(string[] args)
    {
        Banco b = new Banco();

        b.imprime(b.emprestimo(1000,12));
        b.imprime(b.juros(1000,.06));
         b.imprime(b.prestacao(60,83));
    }
}
