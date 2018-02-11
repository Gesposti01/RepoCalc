using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryCalc
{
   public static  class Calcolatrice
    {
        public static double Somma(double a, double b)
        {
            double ris = a + b ;

            return ris;
        }
        public static double Divisione(double a, double b)
        {
            double ris = a / b;

            return ris;
        }
        public static double Sottrazione(double a, double b)
        {
            double ris = a - b;

            return ris;
        }
        public static double Prodotto(double a, double b)
        {
            double ris = a * b;

            return ris;
        }
        public static double Massimo(double a, double b)
        {
            double max = 0;
            if (a > b)
            {
                max = a;
            }
            if (a < b)
            {
                max = b;
            }
            if (a == b)
            {
                max = a;
            }

            return max;
        }
        public static double Minimo(double a, double b)
        {
            double min = 0;
            if (a < b)
            {
                min = a;
            }
            if (a > b)
            {
                min = b;
            }
            if (a == b)
            {
                min = a;
            }

            return min;
        }
        public static double Media(double a, double b)
        {
            double ris = (a * b)/2;

            return ris;
        }
    }
}
