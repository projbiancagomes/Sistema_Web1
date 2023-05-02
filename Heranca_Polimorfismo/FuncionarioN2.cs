namespace Heranca_Polimorfismo;
class FuncionarioN2:Funcionario
{
    public override double Participacao(){
        return base.Participacao() * .02;
    }
}
