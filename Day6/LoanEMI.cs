using System;
namespace loan
{
    class LoanEMI
    {
       static int monthlyPayment()
        {
            Console.WriteLine("Enter loan ammount");
            int P = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rate of interest");
            int R = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Years till you want to pay emi");
            int Y = int.Parse(Console.ReadLine());
            int n = 12 * Y;
            int r = (R / (12 * 100));
            int cal = (1 - (1 + r) ^ (n));
            int payment = ((P * r)/cal);
            return payment;
        }
      
        static void Main(string[] args)
        {
            int emi = LoanEMI.monthlyPayment();
            Console.WriteLine("EMI : " + emi);
         }
    }
}
