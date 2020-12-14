using System;

namespace ContaBancaria2
{
    class SistemaBanco
    {

        public static Conta CriarConta()
        {
            Console.Write("Entre com o número da conta: ");
            string numero = Console.ReadLine();

            Console.Write("Entre com o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Deseja fazer um saque inicial (s/n) ?");
            string saqueInicial = Console.ReadLine();

            double saldo = 0;
            if (saqueInicial.Equals("s"))
            {
                Console.Write("Entre com o saldo inicial: ");
                saldo = double.Parse(Console.ReadLine());
            }
            else
            {
                saldo = 0;
            }

            return new Conta(numero, titular, saldo);
        }

        public static void Depositar(Conta conta)
        {

            Console.WriteLine("Digite o valor para depósito");
            double deposito = double.Parse(Console.ReadLine());

            conta.Saldo += deposito;

            SistemaBanco.AtualizarConta(conta);
        }

        public static void Sacar(Conta conta)
        {

            Console.WriteLine("Digite o valor para saque");
            double saque = double.Parse(Console.ReadLine());

            if (saque <= conta.LimiteDeSaque)
            {
                conta.Saldo -= saque + 5;
                SistemaBanco.AtualizarConta(conta);
            }
            else
            {
                Console.WriteLine("Você não pode efetuar um saque desta quantia");
            }
        }
        public static void AtualizarConta(Conta conta)
        {
            if (conta.Saldo <= 1500)
            {
                conta.LimiteDeSaque = 200;
                conta.Tipo = TipoConta.Gold;
            }
            else if (conta.Saldo > 1500 && conta.Saldo <= 5000)
            {
                conta.LimiteDeSaque = 500;
                conta.Tipo = TipoConta.Platinum;
            }
            else if (conta.Saldo > 5000)
            {
                conta.LimiteDeSaque = 1000;
                conta.Tipo = TipoConta.Black;
            }
        }
    }
}
