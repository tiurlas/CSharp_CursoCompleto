using System;
using System.Globalization;

namespace ExercicioProposto2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcent)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto / 100 * porcent);
        }

        public override string ToString()
        {
            return Nome 
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
