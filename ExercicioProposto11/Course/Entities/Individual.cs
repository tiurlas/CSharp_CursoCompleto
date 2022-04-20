namespace Course.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnualIncome > 20000.00)
            {
                tax = 0.25;
            }
            else
            {
                tax = 0.15;
            }

            double sum = 0.0;
            if (HealthExpenditures > 0.0)
            {
                 sum = (AnualIncome * tax) - (HealthExpenditures * 0.50);
            }
            return sum;
        }
    }
}
