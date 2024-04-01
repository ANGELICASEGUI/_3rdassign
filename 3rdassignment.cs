using System;
namespace _3rdassignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Seconds: ");
            string s= Console.ReadLine();
            float S = float.Parse(s);

            float StM = float.Parse(s) / 30;
            float MtH = float.Parse(s) / 30;
            float HtD = float.Parse(s) / 24;
            float DtM = float.Parse(s) / 24;


            Console.WriteLine("SecondtoMinutes: "+ StM + "Minutes");
            Console.WriteLine("MinutestoHours: " + MtH + "Hours");
            Console.WriteLine("HourstoDays: "+ HtD + "Days");
            Console.WriteLine("DaystoMonths: " + DtM + "Months");
        }
    }
}
