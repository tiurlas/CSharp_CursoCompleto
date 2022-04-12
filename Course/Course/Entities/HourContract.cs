using System;

namespace Course.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValurPerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valurPerHour, int hours)
        {
            Date = date;
            ValurPerHour = valurPerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValurPerHour * Hours;
        }
    }
}
