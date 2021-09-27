using System;
namespace wage
{
    class Wage
    {
        static void Main(string[] args)
        {
            EmpWage obj = new EmpWage();
            obj.emp();
        }
    }
    public class EmpWage
    {
        public void emp()
        {
            int fullHour = 8;
            int halfHour = fullHour / 2;
            int empWagePerHour = 20;
            int month = 20;
            int totalWage = 0;
            int wage = 0;

            for (int i = 1; i <= month; i++)
            {
                Random rand = new Random();
                int attendance = rand.Next(1,4);

                switch (attendance)
                {
                    case 1:
                        wage = fullHour * empWagePerHour;
                        totalWage = totalWage + wage;
                        Console.WriteLine("Full Day");
                        Console.WriteLine("Wage : " + wage);
                        break;
                    case 2:
                        wage = halfHour * empWagePerHour;
                        totalWage = totalWage + wage;
                        Console.WriteLine("Half Day");
                        Console.WriteLine("Wage : " + wage);
                        break;
                    case 3:
                        Console.WriteLine("Employee is absent");
                        Console.WriteLine("No Wage Calculated");
                        break;
                }
            }
            Console.WriteLine("Total Monthly Wage : "+totalWage);

        }

    }

}