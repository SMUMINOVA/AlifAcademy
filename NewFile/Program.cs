using System;

namespace NewFile
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 16.80;
            double b = 12.40;
            Console.WriteLine("(16.80*12.40)^(1/2) = " + Math.Sqrt(a*b));
            double A = 1.4;
            double B = -5.5;
            double C = 0.6;
            double AC = A - C;
            double BC = C - B;
            double Summ = AC + BC;
            Console.WriteLine("AC = " + AC);
            Console.WriteLine("BC = " + BC);
            Console.WriteLine("AC + BC = " + Summ);
            double x1 = -6.20;
            double y1 = 5.20;
            double x2 = 2.10;
            double y2 = 9.80;
            Console.WriteLine("результат = " + Math.Sqrt( Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            int numb = 41;
            int firstNumb = numb % 10;
            int secondNumb = numb / 10;
            int newNumb = secondNumb + firstNumb * 10;
            Console.WriteLine("41 = " + newNumb);
            int N = 10958;
            Console.WriteLine("результат = " + (N / 60));
            int daysOfYear = 202;
            Console.WriteLine( "Номер дня недели " + (daysOfYear % 7));
            Console.ReadKey();
        }
    }
}
