using System;
using System.Collections.Generic;

namespace Course
{
    class ConversorDeMoeda
    {
        
        public static double ValorPago(double dolar, double quantidade)
        {
            double iof = dolar * quantidade * 0.06;
            return dolar * quantidade + iof;
        }
    }
}
