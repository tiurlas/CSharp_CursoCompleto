using System.Globalization;

namespace Course
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, string nome)
        {
            NumeroConta = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
