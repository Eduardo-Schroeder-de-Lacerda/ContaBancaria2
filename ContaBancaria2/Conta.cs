namespace ContaBancaria2
{
    class Conta
    {
        public string Numero { get; set; }
        public double Saldo { get; set; }
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

        public override string ToString()
        {
            return "Conta: " + Numero +
                   ", Titular: " + Titular +
                   ", Saldo: $ " + Saldo.ToString("F2") +
                   ", Tipo: " + Tipo;
        }
    }
}