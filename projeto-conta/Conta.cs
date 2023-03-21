namespace projeto_conta;
class Conta
{
   public int Numero {get; set;}
   private double Saldo {get; set;}
   public double Limite {get;private set;}

   public void AjustarLimite(double valor){
     this.Limite = valor;
   }
     
   public void Depositar(double valor){
       this.Saldo += valor;
   }
    public void Sacar(double valor){
       if(valor <- this.Saldo + this.Limite){
          this.Saldo -= valor;
       }else{
          Console.WriteLine("Você não possui saldo+ limite suficiente para esse Saque!");
           Console.WriteLine("Saque não realizado");
       }
      
   }

   public double MostrarSaldo(){
       return this.Saldo + this.Limite;
   }
}
