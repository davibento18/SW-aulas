namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação!");
        
        //instanciando os objetos de cada classe
        CartaodeCredito cdc = new CartaodeCredito();
        Cliente cli = new Cliente();

        //Adicionando um nome para um cliente
        cli.Nome = "Davi";

        //Adicionando número e validade do Cartão de Crédito
        cdc.Numero = "208875876";
        cdc.DataValidade = "07/2024";

        //Associando o cliente ao atributo de agregação em Cartão de Credito
        cdc.Cliente = cli;

        //Visualizando as informações
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);

    }
}