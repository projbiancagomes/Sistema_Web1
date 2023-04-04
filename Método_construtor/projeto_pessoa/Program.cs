namespace projeto_pessoa;
class Program
{
    static void Main(string[] args)
    {
         Pessoa p1 = new Pessoa("FULANO",23);
         //p1.InsereNome("BIANCA");
         //p1.InsereSobreNome("GOMES");
         //p1.InsereIdade(16);

         p1.MostrarDados();
    }
}
