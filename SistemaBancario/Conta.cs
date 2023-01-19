using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Conta
    {

        //informações da conta 

        public int Agencia { get; set; }

        public int NumeroConta { get; set; }

        public string NomeConta { get; set; }

        public Titular Titular { get; set; }

        public Decimal Saldo { get; set; }


        //Mostra o saldo atual da conta.
        public Decimal VerSaldo()
        {
            return Saldo;
        }

        //Mostra o valor após o deposito.
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        //Ações de realização de saque
        public void Sacar (decimal valor)
        {

            //Saque autorizado caso o valor seja igual ou menor ao que contém na conta.
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }


            // Caso o If não seja atendido esta mensagem aparece, mostrando ao cliente não tem saldo em conta.
            else
            {
                Console.WriteLine("Saque não pode ser realizado, por falta de saldo.");
            }
        }
    }

 
}
