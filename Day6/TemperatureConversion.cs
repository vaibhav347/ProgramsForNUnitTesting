using System;
namespace temp
{
    class TemperatureConversion
    {
        static int toCelcius()
        {
            Console.WriteLine("Enter Temperature In Faranhit");
            int f = int.Parse(Console.ReadLine());
            int cel = ((f - 32) * 5 / 9);
            Console.WriteLine("Temperature In Faranhit : "+f);
            return cel;
        }
        int toFaran()
        {
            Console.WriteLine("Enter Temperature In Celcius");
            int c = int.Parse(Console.ReadLine());
            int far = ((c * 9 / 5) + 32);
            Console.WriteLine("Temperature In Celcius : "+c);
            return far;
        }
        static void Main(string[] args)
        {
            
            int faranToCel = TemperatureConversion.toCelcius();
            Console.WriteLine("Faranhit to celcius : " + faranToCel);
            Console.WriteLine("\n");
            int celToFaran = TemperatureConversion.toFaran();
           Console.WriteLine("Celcius to faranhit : " + celToFaran);
         }
    }
}
