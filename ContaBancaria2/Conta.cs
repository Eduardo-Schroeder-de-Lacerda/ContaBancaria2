namespace ContaBancaria2
{
    class Conta
    {
        public string Numero { get; set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }
        public TipoConta Tipo { get; set; }
        public double LimiteDeSaque { get; set; }

        public Conta(string numero, string titular, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
            Titular = titular;

            if (saldo <= 1500)
            {
                LimiteDeSaque = 200;
                Tipo = TipoConta.Gold;
            }
            else if (saldo > 1500 && saldo <= 5000)
            {
                LimiteDeSaque = 500;
                Tipo = TipoConta.Platinum;
            }
            else if (saldo > 5000)
            {
                LimiteDeSaque = 1000;
                Tipo = TipoConta.Black;
            }
        }

        public Conta(string numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public static void Sacar(Conta conta, double saque)
        {
            conta.Saldo -= saque + 5;
            SistemaBanco.AtualizarConta(conta);
        }

        public static void Depositar(Conta conta, double deposito)
        {
            conta.Saldo += deposito;
            SistemaBanco.AtualizarConta(conta);
        }

        public override string ToString()
        {
            return "Conta: " + Numero +
                   ", Titular: " + Titular +
                   ", Saldo: $ " + Saldo.ToString("F2") +
                   ", Tipo: " + Tipo;
        }
    }
}