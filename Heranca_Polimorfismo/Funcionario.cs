﻿namespace Heranca_Polimorfismo;
class Funcionario
{
   public string? Nome {get; set;}
   public int Idade {get; set;}

   public virtual double Participacao(){
    return 12000;
   }
}
