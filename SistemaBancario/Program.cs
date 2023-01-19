using SistemaBancario;

namespace Consoleteste
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Informações da Conta, contendo o NomeConta, NumeroConta, Agencia e Saldo.

            var conta = new Conta();          
            conta.NomeConta = "Conta Teste."; //Nome da Conta
            conta.NumeroConta = 1000; //Número da conta
            conta.Agencia = 001; //Número da Agencia
            conta.Saldo = 1000; //Saldo da Conta

            //Informações do Titular da Conta .(informações fictícias)

            conta.Titular = new Titular()
            {
                Cpf = "00309809845",
                Rg = "565739087",
                Endereco = "Rua Submundo",
                Nome = "Domflamingo"
            };

            //Ações feitas feitas pelo Titular, deposito, saque e uma tentativa de sacar um valor além de seu saldo limite. 


            Console.WriteLine($"O saldo atual é: { conta.VerSaldo()}"); //Mostra seu Saldo antes de realizar o deposito

            conta.Depositar(150); //Valor depositado.

            Console.WriteLine($"Saldo atual, após depositar é:  { conta.VerSaldo()}"); //Mostra o Valor após depositar.

            conta.Sacar(900); // Valor do saque realizado.

            Console.WriteLine($"Saldo atual. após saque é:  {conta.VerSaldo()}"); //Valor do saldo após saque.

            conta.Sacar(2000); //Tentativa de realização de saque, com valor acima do saldo

            Console.ReadKey();
        }

    }
}